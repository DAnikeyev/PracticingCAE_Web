using System.Text;

namespace PracticingCAE.Web.Services;

public static class AnswerChecker
{
    /// <summary>
    /// Canonicalises a typed answer: trim, collapse whitespace, unify quotes/dashes,
    /// lowercase, strip trailing punctuation. MCQ and typed answers both go through this
    /// so "The  dogs " and "the dogs" match.
    /// </summary>
    public static string Normalize(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return "";

        var sb = new StringBuilder(input.Length);
        foreach (var ch in input.Trim())
        {
            var c = ch switch
            {
                '\u2018' or '\u2019' or '\u02BC' or '`' => '\'',
                '\u201C' or '\u201D' => '"',
                '\u2013' or '\u2014' or '\u2212' => '-',
                '\u00A0' => ' ',
                _ => ch
            };
            sb.Append(c);
        }

        // collapse runs of whitespace (tabs, newlines, NBSP after mapping)
        var text = sb.ToString();
        var normalized = string.Join(' ',
            text.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries));
        normalized = normalized.ToLowerInvariant();

        return normalized.TrimEnd('.', ',', '!', '?', ';', ':');
    }

    /// <summary>True when the user's answer matches the gap's answer (or an accepted variant).</summary>
    public static bool IsCorrect(string? userAnswer, PracticeGap gap)
    {
        if (string.IsNullOrWhiteSpace(userAnswer)) return false;
        var u = Normalize(userAnswer);
        if (u.Length == 0) return false;

        if (Normalize(gap.Answer) == u) return true;
        foreach (var alt in gap.Accept)
            if (Normalize(alt) == u) return true;
        return false;
    }

    /// <summary>Number of words in a typed answer (used for the Part 4 three-to-six word rule).</summary>
    public static int WordCount(string? text)
    {
        if (string.IsNullOrWhiteSpace(text)) return 0;
        return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public static bool WordCountValid(string? text, int min, int max)
    {
        var n = WordCount(text);
        return n >= min && n <= max;
    }

    /// <summary>Best expected answer to display to the user (answer or first accepted variant).</summary>
    public static string DisplayAnswer(PracticeGap gap) => gap.Answer;
}
