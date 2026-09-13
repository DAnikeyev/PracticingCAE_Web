namespace PracticingCAE.Web.Services;

/// <summary>How a set is rendered and answered.</summary>
public enum SetKind
{
    /// <summary>Multiple-choice cloze: one text, gaps with 4 options (CAE R&UE Part 1).</summary>
    Rue1,
    /// <summary>Open cloze: one text, gaps answered by typing a word (CAE R&UE Part 2).</summary>
    Rue2,
    /// <summary>Word formation: one text, gaps answered using a base word (CAE R&UE Part 3).</summary>
    Rue3,
    /// <summary>Key word transformations: sentence rewriting (CAE R&UE Part 4).</summary>
    Rue4,
    /// <summary>Topic drill: standalone sentence items (type the answer or pick an option).</summary>
    Topic
}

public sealed class TaskDef
{
    public string Id { get; set; } = "";
    public SetKind Kind { get; set; }
    public string Title { get; set; } = "";
    public string Subtitle { get; set; } = "";
    public string Description { get; set; } = "";
    /// <summary>Card grouping on the home page, e.g. "Reading &amp; Use of English".</summary>
    public string Group { get; set; } = "";
    public string Emoji { get; set; } = "";
    public int QuestionsPerSet { get; set; } = 8;
}

/// <summary>One answerable blank. Which members matter depends on the set kind.</summary>
public sealed class PracticeGap
{
    /// <summary>The correct answer (single word/phrase). For MCQ this must be one of <see cref="Options"/>.</summary>
    public string Answer { get; set; } = "";
    /// <summary>Additional accepted spellings/variants (checked case-insensitively after normalisation).</summary>
    public List<string> Accept { get; set; } = new();
    /// <summary>MCQ options. Empty for typed answers.</summary>
    public List<string> Options { get; set; } = new();
    /// <summary>Rue3: base word shown in capitals, e.g. DETERMINE.</summary>
    public string? Base { get; set; }
    /// <summary>Rue4: the key word that must be used, e.g. TURNED.</summary>
    public string? Keyword { get; set; }
    /// <summary>Rue4: the given (lead) sentence.</summary>
    public string? Lead { get; set; }
    /// <summary>Standalone sentence containing ___ where the answer goes (Rue4 item, Topic items).</summary>
    public string? Sentence { get; set; }
    public string? Hint { get; set; }
    public string? Explanation { get; set; }
}

public sealed class PracticeSet
{
    public string Id { get; set; } = "";
    public string TaskId { get; set; } = "";
    public string? Title { get; set; }
    /// <summary>Cloze text with {<!---->{1}}..{<!---->{n}} gap markers (Rue1/Rue2/Rue3).</summary>
    public string? Text { get; set; }
    /// <summary>"exam-style" (full CAE format) or "drill" (focused practice).</summary>
    public string Source { get; set; } = "exam-style";
    public List<PracticeGap> Gaps { get; set; } = new();
}

public sealed record GapResult(
    int Index,
    string UserAnswer,
    bool IsCorrect,
    bool HintShown,
    string ExpectedAnswer,
    string? Explanation);

public sealed record SetResult(bool Correct, bool HintUsed, IReadOnlyList<GapResult> Gaps)
{
    public int CorrectCount => Gaps.Count(g => g.IsCorrect);
    public int Total => Gaps.Count;
}
