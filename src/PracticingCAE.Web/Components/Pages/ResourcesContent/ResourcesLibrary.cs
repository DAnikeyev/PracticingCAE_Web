namespace PracticingCAE.Web.Components.Pages.ResourcesContent;

/// <summary>Registry of resource-guide sections rendered at /resources/{slug}. (Stub — to be replaced.)</summary>
public static class ResourcesLibrary
{
    public sealed record Section(string Slug, string Title);

    public static readonly IReadOnlyList<Section> Sections = new[]
    {
        new Section("overview", "How to use this guide"),
    };

    public static Section? Find(string slug) =>
        Sections.FirstOrDefault(s => s.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
}
