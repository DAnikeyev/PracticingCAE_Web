using System.Text.Json;
using System.Text.RegularExpressions;

namespace PracticingCAE.Web.Services;

/// <summary>
/// Loads the practice content from the content/ directory (task definitions and sets)
/// and indexes it. Content is read-only at runtime; new sets are added by dropping
/// JSON files into content/sets/&lt;taskId&gt;/.
/// </summary>
public sealed partial class ContentRepository
{
    public static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web);

    [GeneratedRegex(@"\{\{(\d+)\}\}")]
    private static partial Regex GapMarker();

    private readonly ILogger<ContentRepository> _logger;
    private readonly Dictionary<string, TaskDef> _tasks = new();
    private readonly Dictionary<string, List<PracticeSet>> _setsByTask = new(StringComparer.OrdinalIgnoreCase);
    private readonly Dictionary<string, PracticeSet> _setsById = new(StringComparer.OrdinalIgnoreCase);
    public IReadOnlyDictionary<string, List<PracticeSet>> SetsByTask => _setsByTask;

    public ContentRepository(ILogger<ContentRepository> logger)
    {
        _logger = logger;
        var root = ResolveContentRoot();
        LoadTasks(Path.Combine(root, "tasks"));
        LoadSets(Path.Combine(root, "sets"));
        _logger.LogInformation("Content loaded: {Tasks} tasks, {Sets} sets",
            _tasks.Count, _setsById.Count);
    }

    public static string ResolveContentRoot()
    {
        var env = Environment.GetEnvironmentVariable("CONTENT_DIR");
        if (!string.IsNullOrWhiteSpace(env)) return env;

        // walk up from the app base directory so tests/tools find the repo content folder
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        for (var i = 0; i < 8 && dir is not null; i++)
        {
            var candidate = Path.Combine(dir.FullName, "content");
            if (Directory.Exists(candidate)) return candidate;
            dir = dir.Parent!;
        }
        return Path.Combine(AppContext.BaseDirectory, "content");
    }

    public IReadOnlyList<TaskDef> Tasks => _tasks.Values.OrderBy(t => t.Group).ThenBy(t => t.Id).ToList();

    public TaskDef? FindTask(string taskId) =>
        _tasks.TryGetValue(taskId, out var t) ? t : null;

    public IReadOnlyList<PracticeSet> SetsFor(string taskId) =>
        _setsByTask.TryGetValue(taskId, out var list) ? list : Array.Empty<PracticeSet>();

    public int SetCount(string taskId) => SetsFor(taskId).Count;

    private int? _rue2MaxAnswerLength;

    /// <summary>
    /// Longest Part 2 answer in the bank. The inline cloze fields are all sized
    /// to this so a field's width never reveals its answer's length.
    /// </summary>
    public int Rue2MaxAnswerLength()
    {
        if (_rue2MaxAnswerLength is null)
        {
            _rue2MaxAnswerLength = SetsFor("rue-part2")
                .SelectMany(s => s.Gaps)
                .Select(g => g.Answer.Length)
                .DefaultIfEmpty(8)
                .Max();
        }
        return _rue2MaxAnswerLength.Value;
    }

    public PracticeSet? FindSet(string setId) =>
        _setsById.TryGetValue(setId, out var s) ? s : null;

    public static (string before, string gap, string after)? SplitSentence(string sentence)
    {
        var idx = sentence.IndexOf("___", StringComparison.Ordinal);
        if (idx < 0) return null;
        return (sentence[..idx], "___", sentence[(idx + 3)..]);
    }

    /// <summary>Splits a cloze text into alternating plain segments and gap numbers.</summary>
    public static List<(string? Text, int? Gap)> ParseCloze(string? text)
    {
        var result = new List<(string?, int?)>();
        if (string.IsNullOrEmpty(text)) return result;
        var matches = GapMarker().Matches(text);
        var pos = 0;
        foreach (Match m in matches)
        {
            if (m.Index > pos)
                result.Add((text[pos..m.Index], null));
            result.Add((null, int.Parse(m.Groups[1].Value)));
            pos = m.Index + m.Length;
        }
        if (pos < text.Length)
            result.Add((text[pos..], null));
        return result;
    }

    private void LoadTasks(string dir)
    {
        if (!Directory.Exists(dir)) return;
        foreach (var file in Directory.EnumerateFiles(dir, "*.json"))
        {
            try
            {
                var def = JsonSerializer.Deserialize<TaskDef>(File.ReadAllText(file), JsonOptions);
                if (def is null || string.IsNullOrWhiteSpace(def.Id)) continue;
                _tasks[def.Id] = def;
                _setsByTask[def.Id] = new List<PracticeSet>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to parse task file {File}", file);
            }
        }
    }

    private void LoadSets(string dir)
    {
        if (!Directory.Exists(dir)) return;
        foreach (var taskDir in Directory.EnumerateDirectories(dir))
        {
            var taskId = Path.GetFileName(taskDir);
            if (!_tasks.ContainsKey(taskId))
            {
                _logger.LogWarning("Sets directory {Dir} has no matching task definition; skipping", taskDir);
                continue;
            }
            foreach (var file in Directory.EnumerateFiles(taskDir, "*.json"))
            {
                try
                {
                    var set = JsonSerializer.Deserialize<PracticeSet>(File.ReadAllText(file), JsonOptions);
                    if (set is null || string.IsNullOrWhiteSpace(set.Id)) continue;
                    set.TaskId = taskId;
                    if (!_setsById.TryAdd(set.Id, set))
                    {
                        _logger.LogWarning("Duplicate set id {SetId} in {File}; keeping first", set.Id, file);
                        continue;
                    }
                    _setsByTask[taskId].Add(set);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Failed to parse set file {File}", file);
                }
            }
        }
        foreach (var list in _setsByTask.Values)
            list.Sort((a, b) => string.CompareOrdinal(a.Id, b.Id));
    }
}
