namespace PracticingCAE.Web.Data;

/// <summary>One completed set attempt. OwnerId is "u:{userId}" or "a:{anonGuid}".</summary>
public class AttemptRecord
{
    public long Id { get; set; }
    public string OwnerId { get; set; } = "";
    public string TaskId { get; set; } = "";
    public string SetId { get; set; } = "";
    public int ItemCount { get; set; }
    public int CorrectCount { get; set; }
    public bool HintUsed { get; set; }
    public bool AnswersRevealed { get; set; }
    public DateTime TimestampUtc { get; set; }
    public List<GapAnswerRecord> Gaps { get; set; } = new();
}

/// <summary>Per-gap detail of an attempt, for mistake analysis.</summary>
public class GapAnswerRecord
{
    public long Id { get; set; }
    public long AttemptId { get; set; }
    public AttemptRecord? Attempt { get; set; }
    public int GapIndex { get; set; }
    public string UserAnswer { get; set; } = "";
    public string ExpectedAnswer { get; set; } = "";
    public bool IsCorrect { get; set; }
    public bool HintShown { get; set; }
}

/// <summary>Which sets an owner has already been served (drives "prefer unseen" selection).</summary>
public class SeenSetRecord
{
    public long Id { get; set; }
    public string OwnerId { get; set; } = "";
    public string TaskId { get; set; } = "";
    public string SetId { get; set; } = "";
    public int TimesSeen { get; set; }
    public DateTime LastSeenUtc { get; set; }
}
