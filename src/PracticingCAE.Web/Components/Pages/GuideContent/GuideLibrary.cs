namespace PracticingCAE.Web.Components.Pages.GuideContent;

/// <summary>Registry of exam-guide sections rendered at /guide/{slug}. (Stub — to be replaced.)</summary>
public static class GuideLibrary
{
    public sealed record Section(string Slug, string Title);

    public static readonly IReadOnlyList<Section> Sections = new[]
    {
        new Section("overview", "Exam overview"),
    };

    public static Section? Find(string slug) =>
        Sections.FirstOrDefault(s => s.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
}
