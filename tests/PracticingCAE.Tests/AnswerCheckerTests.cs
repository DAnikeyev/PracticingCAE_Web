using PracticingCAE.Web.Services;
using Xunit;

namespace PracticingCAE.Tests;

public class AnswerCheckerTests
{
    private static PracticeGap Gap(string answer, string[]? accept = null, string[]? options = null) => new()
    {
        Answer = answer,
        Accept = accept?.ToList() ?? new List<string>(),
        Options = options?.ToList() ?? new List<string>()
    };

    [Theory]
    [InlineData("the dog", "The  Dog ")]
    [InlineData("it's", "it’S")]
    [InlineData("it's", "it’s")]
    [InlineData("mother-in-law", "mother–in–law")]
    public void Normalize_HandlesCaseWhitespaceAndTypography(string expected, string input)
    {
        Assert.Equal(AnswerChecker.Normalize(expected), AnswerChecker.Normalize(input));
    }

    [Fact]
    public void Normalize_StripsTrailingPunctuation()
    {
        Assert.Equal(AnswerChecker.Normalize("no sooner had he left"), AnswerChecker.Normalize("No sooner had he left."));
    }

    [Fact]
    public void Normalize_CollapsesWhitespace()
    {
        Assert.Equal("a lot of", AnswerChecker.Normalize("  a   lot\t of  "));
    }

    [Fact]
    public void IsCorrect_MatchesAnswerCaseInsensitively()
    {
        Assert.True(AnswerChecker.IsCorrect("REMARKABLY", Gap("remarkably")));
    }

    [Fact]
    public void IsCorrect_MatchesAcceptedVariants()
    {
        var gap = Gap("needn't have cooked", accept: new[] { "didn't need to cook" });
        Assert.True(AnswerChecker.IsCorrect("didn't need to cook", gap));
        Assert.True(AnswerChecker.IsCorrect("Needn't have cooked", gap));
    }

    [Fact]
    public void IsCorrect_RejectsWrongAndEmpty()
    {
        var gap = Gap("at");
        Assert.False(AnswerChecker.IsCorrect("in", gap));
        Assert.False(AnswerChecker.IsCorrect("", gap));
        Assert.False(AnswerChecker.IsCorrect(null, gap));
        Assert.False(AnswerChecker.IsCorrect("   ", gap));
    }

    [Fact]
    public void WordCount_CountsWords()
    {
        Assert.Equal(0, AnswerChecker.WordCount("   "));
        Assert.Equal(4, AnswerChecker.WordCount("no sooner had he"));
        Assert.Equal(6, AnswerChecker.WordCount("one two three four five six"));
    }

    [Fact]
    public void WordCountValid_EnforcesRange()
    {
        Assert.True(AnswerChecker.WordCountValid("should have told", 3, 6));
        Assert.False(AnswerChecker.WordCountValid("to go", 3, 6));
        Assert.False(AnswerChecker.WordCountValid("a b c d e f g", 3, 6));
    }
}
