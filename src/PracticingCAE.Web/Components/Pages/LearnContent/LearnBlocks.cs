using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace PracticingCAE.Web.Components.Pages.LearnContent;

/// <summary>One block of static content inside a cheat-sheet section.</summary>
public abstract record LearnBlock
{
    /// <summary>Short paragraph. Supports <c>**bold**</c>, <c>*italic*</c> and <c>~~strike~~</c> inline markup.</summary>
    public sealed record Para(string Text) : LearnBlock;

    /// <summary>Highlighted trap / tip box.</summary>
    public sealed record Note(string Text) : LearnBlock;

    /// <summary>Bulleted list of short items.</summary>
    public sealed record Bullets(params string[] Items) : LearnBlock;

    /// <summary>Boxed example sentences.</summary>
    public sealed record Examples(params string[] Lines) : LearnBlock;

    /// <summary>Side-by-side recommended vs not-recommended lists.</summary>
    public sealed record DoDont(string[] Dos, string[] Donts) : LearnBlock;

    /// <summary>Reference table. Cells accept the same inline markup as paragraphs.</summary>
    public sealed record Table(string[] Headers, params string[][] Rows) : LearnBlock;
}

/// <summary>A titled group of blocks rendered as one &lt;section&gt; with an anchor.</summary>
public sealed record LearnSection(string Heading, params LearnBlock[] Blocks);

/// <summary>Inline-markup and anchor helpers for cheat-sheet content.</summary>
public static partial class LearnText
{
    private static readonly Regex Bold = new(@"\*\*(.+?)\*\*", RegexOptions.Compiled);
    private static readonly Regex Italic = new(@"\*(.+?)\*", RegexOptions.Compiled);
    private static readonly Regex Strike = new(@"~~(.+?)~~", RegexOptions.Compiled);

    /// <summary>HTML-encodes text, then expands the tiny markup subset to tags.</summary>
    public static string Inline(string text)
    {
        var s = WebUtility.HtmlEncode(text);
        s = Bold.Replace(s, "<b>$1</b>");
        s = Italic.Replace(s, "<i>$1</i>");
        return Strike.Replace(s, "<s>$1</s>");
    }

    /// <summary>Stable HTML id for a section heading.</summary>
    public static string Anchor(string heading)
    {
        var sb = new StringBuilder();
        foreach (var c in heading.ToLowerInvariant())
            sb.Append(char.IsAsciiLetterOrDigit(c) ? c : '-');
        return sb.ToString().Trim('-');
    }

    /// <summary>Table-row shorthand so content reads like the rendered table.</summary>
    public static string[] R(params string[] cells) => cells;
}
