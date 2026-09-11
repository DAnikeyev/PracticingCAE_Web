using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using PracticingCAE.Web.Data;
using PracticingCAE.Web.Services;
using Xunit;

namespace PracticingCAE.Tests;

public class ProgressServiceTests : IDisposable
{
    private readonly SqliteConnection _connection;
    private readonly ProgressService _progress;

    public ProgressServiceTests()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();
        var factory = new StubFactory(_connection);
        using var db = factory.CreateDbContext();
        db.Database.EnsureCreated();
        _progress = new ProgressService(factory);
    }

    private static PracticeSet SampleSet(string id = "t-0001") => new()
    {
        Id = id,
        TaskId = "articles",
        Gaps =
        {
            new PracticeGap { Answer = "an", Sentence = "___ hour passed." },
            new PracticeGap { Answer = "the" },
            new PracticeGap { Answer = "–" },
            new PracticeGap { Answer = "a" }
        }
    };

    private static SetResult Result(params bool[] correct) => new(
        correct.All(c => c),
        HintUsed: false,
        correct.Select((c, i) => new GapResult(i, "x", c, false, "", null)).ToList());

    [Fact]
    public async Task SaveAttempt_ThenReadOverview()
    {
        await _progress.SaveAttemptAsync("o1", SampleSet(), Result(true, true, false, true));
        var overview = await _progress.GetOverviewAsync("o1");
        Assert.Equal(1, overview.TotalAttempts);
        Assert.Equal(4, overview.TotalItems);
        Assert.Equal(3, overview.TotalCorrect);
        Assert.Equal(75, overview.OverallAccuracy, 1);
    }

    [Fact]
    public async Task RevealedAttempts_AreExcludedFromAccuracy()
    {
        await _progress.SaveAttemptAsync("o1", SampleSet(), Result(true, true, true, true), answersRevealed: true);
        var overview = await _progress.GetOverviewAsync("o1");
        Assert.Equal(0, overview.TotalAttempts); // nothing counted
        Assert.Equal(0, overview.OverallAccuracy);
    }

    [Fact]
    public async Task TaskStats_ArePerTask()
    {
        await _progress.SaveAttemptAsync("o1", SampleSet(), Result(true, true, true, true));
        var other = SampleSet(); other.TaskId = "prepositions"; other.Id = "p-0001";
        await _progress.SaveAttemptAsync("o1", other, Result(true, false, false, false));
        var stats = await _progress.GetTaskStatsAsync("o1");
        Assert.Equal(2, stats.Count);
        var articles = stats.Single(s => s.TaskId == "articles");
        Assert.Equal(100, articles.Accuracy, 1);
        var preps = stats.Single(s => s.TaskId == "prepositions");
        Assert.Equal(25, preps.Accuracy, 1);
    }

    [Fact]
    public async Task DailySeries_BucketsByUtcDay()
    {
        await _progress.SaveAttemptAsync("o1", SampleSet(), Result(true, true, true, true));
        var series = await _progress.GetDailySeriesAsync("o1", null, 7);
        var today = series.Single();
        Assert.Equal(DateTime.UtcNow.Date, today.Day);
        Assert.Equal(100, today.Accuracy, 1);
    }

    [Fact]
    public async Task AdoptAnonymous_MovesHistoryToUser()
    {
        await _progress.SaveAttemptAsync("a:anon-1", SampleSet(), Result(true, true, true, true));
        var moved = await _progress.AdoptAnonymousAsync("a:anon-1", "u:user-1");
        Assert.Equal(1, moved);
        var overview = await _progress.GetOverviewAsync("u:user-1");
        Assert.Equal(1, overview.TotalAttempts);
        Assert.Equal(0, (await _progress.GetOverviewAsync("a:anon-1")).TotalAttempts);
        // idempotent
        Assert.Equal(0, await _progress.AdoptAnonymousAsync("a:anon-1", "u:user-1"));
    }

    [Fact]
    public async Task TopMistakes_RanksMostMissedAnswers()
    {
        var set = SampleSet();
        // "an" missed twice, "the" once — ties broken by count, not order
        var rows = new List<GapResult>
        {
            new(0, "a hour", false, false, "an", null),
            new(1, "a", false, false, "the", null),
            new(2, "–", true, false, "–", null),
            new(3, "an", false, false, "an", null),
        };
        await _progress.SaveAttemptAsync("o1", set, new SetResult(false, false, rows));
        var other = SampleSet("t-0002");
        await _progress.SaveAttemptAsync("o1", other, new SetResult(false, false, new[]
        {
            new GapResult(0, "a hour", false, false, "an", null),
            new GapResult(1, "the", true, false, "the", null),
            new GapResult(2, "–", true, false, "–", null),
            new GapResult(3, "a", true, false, "a", null),
        }));
        var top = await _progress.GetTopMistakesAsync("o1");
        Assert.Equal(2, top.Count);
        Assert.Equal("an", top[0].Expected);
        Assert.Equal(3, top[0].Times);
        Assert.Equal("the", top[1].Expected);
        Assert.Equal(1, top[1].Times);
    }

    public void Dispose()
    {
        _connection.Dispose();
    }

    private sealed class StubFactory(SqliteConnection connection) : IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext() =>
            new(new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection).Options);

        public Task<ApplicationDbContext> CreateDbContextAsync(CancellationToken cancellationToken = default)
            => Task.FromResult(CreateDbContext());
    }
}
