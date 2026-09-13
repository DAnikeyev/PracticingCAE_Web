namespace PracticingCAE.Web.Components.Pages.LearnContent;

/// <summary>Registry of cheat-sheet topics rendered at /learn/{slug}. (Stub — to be replaced.)</summary>
public static class LearnLibrary
{
    public sealed record Topic(string Slug, string Title);

    public static readonly IReadOnlyList<Topic> Topics = new[]
    {
        new Topic("articles", "Articles"),
    };

    public static Topic? Find(string slug) =>
        Topics.FirstOrDefault(t => t.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
}
