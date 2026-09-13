namespace PracticingCAE.Web.Components.Pages.GuideContent;

/// <summary>Registry of exam-guide sections rendered at /guide/{slug}.</summary>
public static class GuideLibrary
{
    public sealed record Section(string Slug, string Title, string Summary);

    public static readonly IReadOnlyList<Section> Sections = new[]
    {
        new Section("overview", "Exam overview",
            "Format of the Reading & Use of English paper, marks per part, and how this site maps to the real exam."),
        new Section("timing", "Time management",
            "A minute-by-minute budget for the 90-minute paper, and what to do when you get stuck."),
        new Section("part-1", "Part 1: Multiple-choice cloze",
            "Read before you choose: word class, collocation and how to eliminate the distractors."),
        new Section("part-2", "Part 2: Open cloze",
            "One word, almost always a function word. How to read the grammar around the gap."),
        new Section("part-3", "Part 3: Word formation",
            "Part of speech first, form the word second. Suffixes, prefixes and spelling traps."),
        new Section("part-4", "Part 4: Key word transformations",
            "Two marks per sentence: 3-6 words including the keyword, meaning unchanged."),
        new Section("common-traps", "Common traps",
            "The highest-frequency mistakes per part, and the checks that catch them."),
        new Section("preparation", "Prepare with this site",
            "A weekly routine: typed mode, accuracy before speed, progress reviews, timed sets."),
    };

    public static Section? Find(string slug) =>
        Sections.FirstOrDefault(s => s.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    public static int IndexOf(Section section) =>
        Sections.ToList().FindIndex(s => s.Slug == section.Slug);
}
