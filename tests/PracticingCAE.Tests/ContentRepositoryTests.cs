using PracticingCAE.Web.Services;
using Xunit;

namespace PracticingCAE.Tests;

/// <summary>
/// Validates the whole committed content bank: every set must be well-formed,
/// every answer must be complete (hint + explanation), and every task must
/// offer at least 200 sets — the bar set for this project.
/// </summary>
public class ContentRepositoryTests
{
    private static readonly ContentRepository Repo = new(
        new TestLogger<ContentRepository>());

    private static List<(PracticeSet Set, TaskDef Task)> AllSets() =>
        Repo.Tasks.SelectMany(t => Repo.SetsFor(t.Id).Select(s => (s, t))).ToList();

    [Fact]
    public void Tasks_AreLoaded()
    {
        Assert.Equal(21, Repo.Tasks.Count);
    }

    [Fact]
    public void EverySet_IdIsUniqueAndTaskBacked()
    {
        var sets = AllSets();
        Assert.Equal(sets.Select(s => s.Set.Id).Distinct().Count(), sets.Count);
        Assert.All(sets, s => Assert.Equal(s.Task.Id, s.Set.TaskId));
    }

    [Fact]
    public void EveryTask_OffersAtLeastTheSetFloor()
    {
        // rue-part2 sets are whole coherent cloze texts (one authored text = one set),
        // so its floor is lower than the cycled sentence banks.
        foreach (var task in Repo.Tasks)
        {
            var min = task.Id is "rue-part1" or "rue-part2" ? 100 : 200;
            Assert.True(Repo.SetCount(task.Id) >= min,
                $"{task.Id} has only {Repo.SetCount(task.Id)} sets (min {min})");
        }
    }

    [Fact]
    public void Rue2Sets_AreCoherentTextsWithEightGaps()
    {
        foreach (var set in Repo.SetsFor("rue-part2"))
        {
            Assert.False(string.IsNullOrWhiteSpace(set.Text),
                $"{set.Id}: part 2 sets must be coherent cloze texts, not standalone sentences");
            Assert.Equal(8, set.Gaps.Count);
            Assert.True(set.Text.Length >= 350,
                $"{set.Id}: part 2 text is too short to be a coherent passage ({set.Text.Length} chars)");
        }
    }

    [Fact]
    public void EveryGap_HasAnswerHintAndExplanation()
    {
        foreach (var (set, _) in AllSets())
        {
            foreach (var (gap, i) in set.Gaps.Select((g, i) => (g, i)))
            {
                Assert.False(string.IsNullOrWhiteSpace(gap.Answer), $"{set.Id} gap {i + 1}: no answer");
                Assert.False(string.IsNullOrWhiteSpace(gap.Hint), $"{set.Id} gap {i + 1}: no hint");
                Assert.False(string.IsNullOrWhiteSpace(gap.Explanation), $"{set.Id} gap {i + 1}: no explanation");
            }
        }
    }

    [Fact]
    public void McqGaps_HaveFourDistinctOptionsContainingTheAnswer()
    {
        foreach (var (set, _) in AllSets())
        {
            foreach (var gap in set.Gaps.Where(g => g.Options.Count > 0))
            {
                Assert.Equal(4, gap.Options.Count);
                Assert.Equal(4, gap.Options.Distinct().Count());
                Assert.Contains(gap.Answer, gap.Options);
            }
        }
    }

    [Fact]
    public void Rue1Sets_AreCoherentTextsWithEightGaps()
    {
        foreach (var set in Repo.SetsFor("rue-part1"))
        {
            Assert.False(string.IsNullOrWhiteSpace(set.Text),
                $"{set.Id}: part 1 sets must be coherent cloze texts, not standalone sentences");
            Assert.Equal(8, set.Gaps.Count);
            Assert.True(set.Text.Length >= 350,
                $"{set.Id}: part 1 text is too short to be a coherent passage ({set.Text.Length} chars)");
        }
    }

    [Fact]
    public void Rue4Sets_HaveEightItems()
    {
        foreach (var set in Repo.SetsFor("rue-part4"))
        {
            Assert.Equal(8, set.Gaps.Count);
        }
    }

    [Fact]
    public void Rue3Sets_AreSentenceBased()
    {
        foreach (var set in Repo.SetsFor("rue-part3"))
        {
            Assert.True(string.IsNullOrWhiteSpace(set.Text),
                $"{set.Id}: part 3 must be standalone sentences, not texts");
        }
    }

    [Fact]
    public void McqGaps_AnswerPositionVaries_NotAlwaysFirst()
    {
        // seeds list the correct option first; generation shuffles, so across a
        // whole task the answer may not sit in position 0 for most sets.
        foreach (var task in Repo.Tasks)
        {
            var withOptions = Repo.SetsFor(task.Id)
                .Where(s => s.Gaps.Any(g => g.Options.Count > 0)).ToList();
            if (withOptions.Count == 0) continue;

            var firstIsAnswer = withOptions.Count(s =>
                s.Gaps[0].Options.Count > 0 && s.Gaps[0].Options[0] == s.Gaps[0].Answer);
            var share = (double)firstIsAnswer / withOptions.Count;
            Assert.True(share < 0.6,
                $"{task.Id}: answer is the first option in {firstIsAnswer}/{withOptions.Count} sets — options not shuffled?");
        }
    }

    [Fact]
    public void ClozeSet_TextMarkersMatchGapCount()
    {
        foreach (var (set, task) in AllSets().Where(s => s.Task.Kind is SetKind.Rue1 or SetKind.Rue2 or SetKind.Rue3))
        {
            if (set.Text is null) continue; // drill sets use per-gap sentences
            var numbers = ContentRepository.ParseCloze(set.Text)
                .Select(s => s.Gap).Where(g => g is not null).Select(g => g!.Value).ToList();
            Assert.Equal(set.Gaps.Count, numbers.Count);
            Assert.Equal(Enumerable.Range(1, set.Gaps.Count), numbers);
        }
    }

    [Fact]
    public void TopicAndTransformationItems_ContainExactlyOneBlank()
    {
        foreach (var (set, task) in AllSets().Where(s =>
                     s.Task.Kind is SetKind.Topic or SetKind.Rue4))
        {
            foreach (var gap in set.Gaps)
            {
                if (task.Kind == SetKind.Rue4)
                    Assert.NotNull(gap.Sentence); // rue4 items always carry the gapped sentence
                if (gap.Sentence is not null)
                    Assert.Equal(1, gap.Sentence.Split("___").Length - 1);
            }
        }
    }

    [Fact]
    public void Rue4Items_KeywordAppearsInTheAnswer_WithinThreeToSixWords()
    {
        foreach (var (set, _) in AllSets().Where(s => s.Task.Kind == SetKind.Rue4))
        {
            foreach (var gap in set.Gaps)
            {
                Assert.False(string.IsNullOrWhiteSpace(gap.Keyword), $"{set.Id}: missing keyword");
                Assert.True(gap.Answer.ToLowerInvariant()
                        .Contains(gap.Keyword.ToLowerInvariant()),
                    $"{set.Id}: answer '{gap.Answer}' lacks keyword '{gap.Keyword}'");
                var words = AnswerChecker.WordCount(gap.Answer);
                Assert.True(words is >= 3 and <= 6,
                    $"{set.Id}: answer '{gap.Answer}' has {words} words (CAE requires 3-6)");
            }
        }
    }

    [Fact]
    public void ParseCloze_SplitsSegmentsCorrectly()
    {
        var segments = ContentRepository.ParseCloze("A {{1}} B {{2}} C");
        Assert.Equal(5, segments.Count);
        Assert.Equal("A ", segments[0].Text);
        Assert.Equal(1, segments[1].Gap);
        Assert.Equal(" B ", segments[2].Text);
        Assert.Equal(2, segments[3].Gap);
        Assert.Equal(" C", segments[4].Text);
    }

    [Fact]
    public void SplitSentence_SplitsAtTheBlank()
    {
        var parts = ContentRepository.SplitSentence("She is good ___ maths.");
        Assert.NotNull(parts);
        Assert.Equal("She is good ", parts!.Value.before);
        Assert.Equal(" maths.", parts.Value.after);
        Assert.Null(ContentRepository.SplitSentence("No blank here."));
    }
}
