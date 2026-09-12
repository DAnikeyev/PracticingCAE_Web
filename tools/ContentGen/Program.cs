using System.Text.Json;
using PracticingCAE.Web.Services;

// ContentGen: reads curated seed banks (tools/ContentGen/Seeds) and deterministically
// generates the practice content into content/ (task definitions + one JSON file per set).
// Run from the repo root:  dotnet run --project tools/ContentGen

var repoRoot = FindRepoRoot();
var seedsDir = Path.Combine(repoRoot, "tools", "ContentGen", "Seeds");
var contentDir = Path.Combine(repoRoot, "content");
var rng = new Random(20260911); // deterministic output — reruns only change content when seeds change

const int TargetSetsPerTask = 110;

var tasks = new List<TaskDef>
{
    new()
    {
        Id = "rue-part1", Kind = SetKind.Rue1,
        Title = "Reading & Use of English — Part 1", Subtitle = "Multiple-choice cloze",
        Description = "Read the text and choose the word (A, B, C or D) that fits each gap. In the exam this part has 8 questions.",
        Group = "Reading & Use of English", Emoji = "📘", QuestionsPerSet = 8
    },
    new()
    {
        Id = "rue-part2", Kind = SetKind.Rue2,
        Title = "Reading & Use of English — Part 2", Subtitle = "Open cloze",
        Description = "Think of the word that best fits each gap. In the exam you write ONE word only — mostly grammar words (articles, prepositions, auxiliaries…).",
        Group = "Reading & Use of English", Emoji = "✏️", QuestionsPerSet = 8
    },
    new()
    {
        Id = "rue-part3", Kind = SetKind.Rue3,
        Title = "Reading & Use of English — Part 3", Subtitle = "Word formation",
        Description = "Use the word in CAPITALS at the end of each line to form a word that fits the gap.",
        Group = "Reading & Use of English", Emoji = "🧩", QuestionsPerSet = 8
    },
    new()
    {
        Id = "rue-part4", Kind = SetKind.Rue4,
        Title = "Reading & Use of English — Part 4", Subtitle = "Key word transformations",
        Description = "Complete the second sentence so that it means the same as the first, using the word given. Use 3–6 words including the key word. Do not change the key word.",
        Group = "Reading & Use of English", Emoji = "🔁", QuestionsPerSet = 6
    },
};

var topics = new List<TaskDef>
{
    Topic("articles", "Articles", "a / an / the / zero article", "Choose or type the correct article — including the tricky zero-article and a-vs-an-by-sound cases.", "🔤"),
    Topic("prepositions", "Dependent Prepositions", "verb/adj/noun + preposition", "agree with, depend on, good at… The collocations the exam loves.", "🔗"),
    Topic("phrasal-verbs", "Phrasal Verbs", "particles and meanings", "Common C1-level phrasal verbs: pick the right particle or the right meaning.", "🚀"),
    Topic("verb-patterns", "Verb Patterns", "-ing vs to-infinitive", "enjoy doing vs want to do, stop doing vs stop to do — the patterns that decide meanings.", "🌀"),
    Topic("tenses", "Tenses", "present, past, perfect, future", "Choose the tense the context calls for: time markers, sequence, states vs events.", "⏳"),
    Topic("conditionals", "Conditionals", "if-clauses and wishes", "Zero to third conditional, mixed conditionals, I wish / if only.", "🔀"),
    Topic("modals", "Modal Verbs", "ability, obligation, deduction", "must/might/can't for deduction, should have done, be able to…", "🎫"),
    Topic("passive-voice", "Passive Voice", "forms and usage", "All tenses in the passive, by + agent, impersonal passives.", "🏗️"),
    Topic("reported-speech", "Reported Speech", "statements, questions, commands", "Backshift, reported questions, tell vs say, reporting verbs.", "💬"),
    Topic("linking-words", "Linking Words", "connectors and discourse markers", "although vs despite, however vs whereas, so that vs in case.", "🌉"),
    Topic("confusable-words", "Confusable Words", "affect/effect, lose/loose…", "Word pairs even advanced learners mix up.", "🤔"),
    Topic("collocations", "Collocations", "natural word combinations", "make vs do, heavy rain, strong coffee, take a decision…", "🧲"),
    Topic("relative-clauses", "Relative Clauses", "who, which, that, whose, where", "Choose the relative pronoun; defining vs non-defining.", "⛓️"),
    Topic("quantifiers", "Quantifiers", "some/any/much/many/few/little", "Countable vs uncountable, (a) few vs (a) little, much/many.", "🔢"),
    Topic("word-formation", "Word Formation Drill", "prefixes and suffixes", "Sentence-level practice of the Part 3 skill: build the right word from the base.", "🧩"),
    Topic("inversion-emphasis", "Inversion & Emphasis", "advanced structures (typed)", "Never had I…, No sooner…than, Should you… — the C1/C2 inversion and emphasis structures, typed answers only.", "🎭"),
    Topic("prepositional-phrases", "Prepositional Phrases", "fixed expressions (typed)", "in time vs on time, under wraps, by far — the fixed preposition phrases C1 exams love, typed answers only.", "🧭"),
};

tasks.AddRange(topics);

Directory.CreateDirectory(contentDir);
Directory.CreateDirectory(Path.Combine(contentDir, "tasks"));

// fresh generation: clear previously generated sets
var setsRoot = Path.Combine(contentDir, "sets");
if (Directory.Exists(setsRoot)) Directory.Delete(setsRoot, true);
Directory.CreateDirectory(setsRoot);

var problems = new List<string>();
var summary = new List<(string Id, int Sets)>();

// ---------- R&UE tasks ----------
summary.Add(("rue-part1", GenerateFullSetsFromSeedFile("rue-part1", Path.Combine(seedsDir, "rue1-texts.json"))));
summary.Add(("rue-part1", GenerateDrillSets("rue-part1", Path.Combine(seedsDir, "rue1-drill-items.json"), itemsPerSet: 8)));
summary.Add(("rue-part2", GenerateFullSetsFromSeedFile("rue-part2", Path.Combine(seedsDir, "rue2-texts.json"))));
summary.Add(("rue-part2", GenerateDrillSets("rue-part2", Path.Combine(seedsDir, "rue2-drill-items.json"), itemsPerSet: 8)));
summary.Add(("rue-part3", GenerateFullSetsFromSeedFile("rue-part3", Path.Combine(seedsDir, "rue3-texts.json"))));
summary.Add(("rue-part3", GenerateDrillSets("rue-part3", Path.Combine(seedsDir, "rue3-drill-items.json"), itemsPerSet: 8, stripOptions: true)));
summary.Add(("rue-part4", GenerateDrillSets("rue-part4", Path.Combine(seedsDir, "rue4-items.json"), itemsPerSet: 6)));

// ---------- topic drills ----------
foreach (var topic in topics.Where(t => t.Kind == SetKind.Topic))
    summary.Add((topic.Id, GenerateDrillSets(topic.Id, Path.Combine(seedsDir, "topics", $"{topic.Id}.json"), itemsPerSet: 8)));
// ---------- write task definitions ----------
foreach (var t in tasks)
{
    t.QuestionsPerSet = t.Kind == SetKind.Rue4 ? 6 : 8;
    var path = Path.Combine(contentDir, "tasks", $"{t.Id}.json");
    File.WriteAllText(path, JsonSerializer.Serialize(t, ContentRepository.JsonOptions));
}

// ---------- summary ----------
Console.WriteLine($"{"task",-22} {"sets",6}  meets >=100");
foreach (var s in summary.GroupBy(x => x.Id).Select(g => (Id: g.Key, Sets: g.Sum(x => x.Sets))))
{
    Console.WriteLine($"{s.Id,-22} {s.Sets,6}  {(s.Sets >= 100 ? "YES" : "NO !!")}");
    if (s.Sets < 100) problems.Add($"{s.Id}: only {s.Sets} sets");
}
Console.WriteLine($"Total sets: {summary.Sum(s => s.Sets)}");

if (problems.Count > 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("CONTENT SHORTFALL / PROBLEMS:");
    foreach (var p in problems) Console.WriteLine(" - " + p);
    Console.ResetColor();
    return 1;
}
return 0;

// ---------- helpers ----------

TaskDef Topic(string id, string title, string sub, string desc, string emoji) => new()
{
    Id = id, Kind = SetKind.Topic, Title = title, Subtitle = sub,
    Description = desc, Group = "Grammar & Vocabulary Topics", Emoji = emoji, QuestionsPerSet = 8
};

string FindRepoRoot()
{
    var dir = new DirectoryInfo(AppContext.BaseDirectory);
    for (var i = 0; i < 10 && dir is not null; i++)
    {
        if (File.Exists(Path.Combine(dir.FullName, "PracticingCAE_Web.sln"))) return dir.FullName;
        dir = dir.Parent!;
    }
    throw new InvalidOperationException("Repo root (PracticingCAE_Web.sln) not found");
}

List<PracticeGap> ReadSeedGaps(string file) =>
    JsonSerializer.Deserialize<List<PracticeGap>>(File.ReadAllText(file), ContentRepository.JsonOptions)
    ?? throw new InvalidOperationException($"Empty seed file {file}");

List<PracticeSet> ReadSeedSets(string file) =>
    JsonSerializer.Deserialize<List<PracticeSet>>(File.ReadAllText(file), ContentRepository.JsonOptions)
    ?? throw new InvalidOperationException($"Empty seed file {file}");

int GenerateFullSetsFromSeedFile(string taskId, string file)
{
    if (!File.Exists(file)) { problems.Add($"missing seed file {file}"); return 0; }
    var sets = ReadSeedSets(file);
    var dir = Path.Combine(setsRoot, taskId);
    Directory.CreateDirectory(dir);
    var n = 0;
    foreach (var set in sets)
    {
        n++;
        set.Id = $"{taskId}-{n:0000}";
        set.TaskId = taskId;
        set.Source = "exam-style";
        ShuffleOptions(set);
        ValidateSet(set, file);
        WriteSet(dir, set);
    }
    return n;
}

int GenerateDrillSets(string taskId, string file, int itemsPerSet, bool stripOptions = false)
{
    if (!File.Exists(file)) { problems.Add($"missing seed file {file}"); return 0; }
    var bank = ReadSeedGaps(file);
    if (stripOptions)
    {
        // Part 3 word formation is always typed — the base word badge guides the answer
        foreach (var gap in bank) gap.Options = new List<string>();
    }
    if (taskId == "rue-part4")
    {
        // CAE rule: 3-6 words including the key word
        foreach (var gap in bank.Where(g => AnswerChecker.WordCount(g.Answer) is < 3 or > 6))
            problems.Add($"{file}: rue4 answer '{gap.Answer}' is {AnswerChecker.WordCount(gap.Answer)} words (must be 3-6)");
    }
    if (bank.Count < itemsPerSet) { problems.Add($"{file}: bank too small ({bank.Count})"); return 0; }

    var dir = Path.Combine(setsRoot, taskId);
    Directory.CreateDirectory(dir);

    // continue numbering after any exam-style sets already written for this task
    var counter = Directory.EnumerateFiles(dir, "*.json").Count();
    var pool = new List<PracticeGap>();
    foreach (var _ in Enumerable.Range(0, TargetSetsPerTask))
    {
        if (pool.Count < itemsPerSet)
            pool.AddRange(bank.OrderBy(_ => rng.Next()).ToList());

        var taken = new List<PracticeGap>();
        var usedInSet = new HashSet<string>();
        foreach (var gap in pool)
        {
            var key = gap.Sentence ?? gap.Base ?? gap.Answer;
            if (usedInSet.Add(key)) taken.Add(gap);
            if (taken.Count == itemsPerSet) break;
        }
        foreach (var t in taken) pool.Remove(t);
        if (taken.Count < itemsPerSet) { problems.Add($"{taskId}: could not fill a set from bank of {bank.Count}"); break; }

        counter++;
        var set = new PracticeSet
        {
            Id = $"{taskId}-{counter:0000}",
            TaskId = taskId,
            Title = $"Drill set {counter}",
            Source = "drill",
            Gaps = taken
        };
        ShuffleOptions(set);
        foreach (var g in set.Gaps) ValidateGap(g, file);
        WriteSet(dir, set);
    }
    return counter;
}

// Deterministically shuffle each gap's options so the correct answer does not
// always sit in the position used by the seed files (they list it first).
void ShuffleOptions(PracticeSet set)
{
    foreach (var g in set.Gaps)
        if (g.Options.Count > 1)
            g.Options = g.Options.OrderBy(_ => rng.Next()).ToList();
}

void ValidateSet(PracticeSet set, string file)
{
    if (set.Gaps.Count == 0) problems.Add($"{file}/{set.Id}: no gaps");
    if (set.Text is not null)
    {
        var markers = ContentRepository.ParseCloze(set.Text).Count(s => s.Gap is not null);
        if (markers != set.Gaps.Count)
            problems.Add($"{file}/{set.Id}: {markers} gap markers but {set.Gaps.Count} gaps");
        for (var i = 1; i <= set.Gaps.Count; i++)
            if (!set.Text.Contains($"{{{{{i}}}}}")) problems.Add($"{file}/{set.Id}: missing marker {i}");
    }
    foreach (var g in set.Gaps) ValidateGap(g, file);
}

void ValidateGap(PracticeGap g, string file)
{
    if (string.IsNullOrWhiteSpace(g.Answer)) problems.Add($"{file}: gap without answer ({g.Sentence ?? g.Lead})");
    if (g.Sentence is not null && g.Sentence.Split("___").Length - 1 != 1)
        problems.Add($"{file}: sentence must contain exactly one ___ ({g.Sentence})");
    if (g.Lead is not null && g.Lead.Contains("___"))
        problems.Add($"{file}: lead sentence must not contain ___ ({g.Lead})");
    if (g.Options.Count > 0)
    {
        if (g.Options.Count != 4) problems.Add($"{file}: gap options != 4 ({g.Answer})");
        if (!g.Options.Contains(g.Answer)) problems.Add($"{file}: options missing the answer ({g.Answer})");
        if (g.Options.Distinct().Count() != g.Options.Count) problems.Add($"{file}: duplicate options ({g.Answer})");
    }
    if (string.IsNullOrWhiteSpace(g.Hint)) problems.Add($"{file}: gap without hint ({g.Answer})");
    if (string.IsNullOrWhiteSpace(g.Explanation)) problems.Add($"{file}: gap without explanation ({g.Answer})");
}

void WriteSet(string dir, PracticeSet set)
{
    var path = Path.Combine(dir, $"{set.Id[^4..]}.json");
    File.WriteAllText(path, JsonSerializer.Serialize(set, ContentRepository.JsonOptions));
}
