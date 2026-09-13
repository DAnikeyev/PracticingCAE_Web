namespace PracticingCAE.Web.Components.Pages.LearnContent;

/// <summary>Registry of cheat-sheet topics rendered at /learn and /learn/{slug}.</summary>
public static class LearnLibrary
{
    /// <summary>One cheat sheet: an ordered list of content sections, grouped on the index.</summary>
    public sealed record Topic(
        string Slug,
        string Title,
        string Blurb,
        string Group,
        params LearnSection[] Sections);

    /// <summary>Index groups, in display order.</summary>
    public static readonly string[] Groups =
    [
        "Grammar",
        "Vocabulary and usage",
        "Exam technique",
    ];

    /// <summary>All topics in canonical (prev/next) order.</summary>
    public static readonly IReadOnlyList<Topic> Topics =
        GrammarTopics.All.Concat(VocabularyTopics.All).Concat(ExamTopics.All).ToList();

    public static Topic? Find(string slug) =>
        Topics.FirstOrDefault(t => t.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    /// <summary>Previous and next topic in canonical order.</summary>
    public static (Topic? Prev, Topic? Next) Neighbours(Topic topic)
    {
        for (var i = 0; i < Topics.Count; i++)
        {
            if (ReferenceEquals(Topics[i], topic))
                return (i > 0 ? Topics[i - 1] : null,
                        i < Topics.Count - 1 ? Topics[i + 1] : null);
        }
        return (null, null);
    }
}
