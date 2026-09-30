using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace PracticingCAE.Web.Components.Pages.ResourcesContent;

/// <summary>One block of static content inside a resource-guide subsection.</summary>
public abstract record ResBlock
{
    /// <summary>Short paragraph. Supports <c>**bold**</c>, <c>*italic*</c> and <c>[text](url)</c> links.</summary>
    public sealed record Para(string Text) : ResBlock;

    /// <summary>Highlighted tip / caveat box.</summary>
    public sealed record Note(string Text) : ResBlock;

    /// <summary>Bulleted list of short items.</summary>
    public sealed record Bullets(params string[] Items) : ResBlock;

    /// <summary>Numbered procedure, rendered as an ordered list.</summary>
    public sealed record Steps(params string[] Items) : ResBlock;

    /// <summary>Reference table. Cells accept the same inline markup as paragraphs.</summary>
    public sealed record Table(string[] Headers, params string[][] Rows) : ResBlock;
}

/// <summary>A titled group of blocks rendered as one &lt;section&gt; with an anchor.</summary>
public sealed record ResSection(string Heading, params ResBlock[] Blocks);

/// <summary>Inline-markup and anchor helpers for resource-guide content.</summary>
public static partial class ResText
{
    private static readonly Regex Bold = new(@"\*\*(.+?)\*\*", RegexOptions.Compiled);
    private static readonly Regex Italic = new(@"\*(.+?)\*", RegexOptions.Compiled);
    private static readonly Regex Strike = new(@"~~(.+?)~~", RegexOptions.Compiled);
    private static readonly Regex Link = new(@"\[([^\]]+)\]\(([^)\s]+)\)", RegexOptions.Compiled);

    /// <summary>HTML-encodes text, then expands the tiny markup subset to tags. External links open in a new tab.</summary>
    public static string Inline(string text)
    {
        var s = WebUtility.HtmlEncode(text);
        s = Bold.Replace(s, "<b>$1</b>");
        s = Italic.Replace(s, "<i>$1</i>");
        s = Strike.Replace(s, "<s>$1</s>");
        return Link.Replace(s, m =>
        {
            var url = m.Groups[2].Value;
            var attrs = url.StartsWith('/') ? "" : " target=\"_blank\" rel=\"noopener\"";
            return $@"<a href=""{url}""{attrs}>{m.Groups[1].Value}</a>";
        });
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
