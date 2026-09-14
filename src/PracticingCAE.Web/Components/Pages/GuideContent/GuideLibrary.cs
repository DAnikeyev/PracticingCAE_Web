namespace PracticingCAE.Web.Components.Pages.GuideContent;

/// <summary>Registry of exam-guide sections rendered at /guide/{slug}.</summary>
public static class GuideLibrary
{
    public sealed record Section(string Slug, string Title, string Summary);

    public static readonly IReadOnlyList<Section> Sections = new[]
    {
        new Section("overview", "Exam overview",
            "Format and marks of the Reading & Use of English paper, where the cheap marks are, and how this site maps to the exam."),
        new Section("timing", "Time management",
            "A minute-by-minute budget with running-clock checkpoints, a triage protocol and a recovery plan for when you fall behind."),
        new Section("part-1", "Part 1: Multiple-choice cloze",
            "A five-step method with a worked example, the distractor taxonomy, and the 25 collocation families that dominate this part."),
        new Section("part-2", "Part 2: Open cloze",
            "The 12 function-word categories behind nearly every answer, cue tables, a worked example, and the spelling traps."),
        new Section("part-3", "Part 3: Word formation",
            "Part of speech first: a position-based decision table, an affix reference, worked examples and the irregular-forms trap list."),
        new Section("part-4", "Part 4: Key word transformations",
            "The rules, how the two marks split, and the 12 highest-frequency transformation patterns with a worked example each."),
        new Section("common-traps", "Common traps",
            "Wrong-to-right tables for each part, plus the 60-second end-of-paper check routine."),
        new Section("preparation", "Prepare with this site",
            "A four-week plan with accuracy gates, and how to use typed mode, mistake history, trend arrows and timed laps."),
    };

    public static Section? Find(string slug) =>
        Sections.FirstOrDefault(s => s.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

    public static int IndexOf(Section section) =>
        Sections.ToList().FindIndex(s => s.Slug == section.Slug);
}
