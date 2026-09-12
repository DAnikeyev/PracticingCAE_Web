using Microsoft.EntityFrameworkCore;
using PracticingCAE.Web.Data;

namespace PracticingCAE.Web.Services;

public sealed record TaskStat(
    string TaskId,
    int Attempts,
    int ItemsAttempted,
    int ItemsCorrect,
    double Accuracy,
    double HintRate,
    DateTime? LastPracticedUtc);

public sealed record DailyPoint(DateTime Day, int Attempts, int Items, int Correct, double Accuracy);

public sealed record ProgressOverview(
    int TotalAttempts,
    int TotalItems,
    int TotalCorrect,
    double OverallAccuracy,
    int SetsStarted);

public sealed class ProgressService(IDbContextFactory<ApplicationDbContext> dbFactory)
{
    public async Task SaveAttemptAsync(string ownerId, PracticeSet set, SetResult result, bool answersRevealed = false)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var attempt = new AttemptRecord
        {
            OwnerId = ownerId,
            TaskId = set.TaskId,
            SetId = set.Id,
            ItemCount = result.Total,
            CorrectCount = answersRevealed ? 0 : result.CorrectCount,
            HintUsed = result.HintUsed,
            AnswersRevealed = answersRevealed,
            TimestampUtc = DateTime.UtcNow
        };
        attempt.Gaps.AddRange(result.Gaps.Select(g => new GapAnswerRecord
        {
            GapIndex = g.Index,
            UserAnswer = g.UserAnswer,
            ExpectedAnswer = g.ExpectedAnswer,
            IsCorrect = g.IsCorrect,
            HintShown = g.HintShown
        }));
        db.Attempts.Add(attempt);
        await db.SaveChangesAsync();
    }

    /// <summary>Reassigns a browser's anonymous history to the freshly logged-in user. Idempotent.</summary>
    public async Task<int> AdoptAnonymousAsync(string anonOwnerId, string userOwnerId)
    {
        if (anonOwnerId == userOwnerId || !anonOwnerId.StartsWith("a:", StringComparison.Ordinal))
            return 0;
        await using var db = await dbFactory.CreateDbContextAsync();
        var attempts = await db.Attempts.Where(a => a.OwnerId == anonOwnerId).ToListAsync();
        var seen = await db.SeenSets.Where(s => s.OwnerId == anonOwnerId).ToListAsync();
        foreach (var a in attempts) a.OwnerId = userOwnerId;
        foreach (var s in seen) s.OwnerId = userOwnerId;
        var count = attempts.Count;
        await db.SaveChangesAsync();
        return count;
    }

    public async Task<ProgressOverview> GetOverviewAsync(string ownerId)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var attempts = await db.Attempts.AsNoTracking().Where(a => a.OwnerId == ownerId && !a.AnswersRevealed).ToListAsync();
        var items = attempts.Sum(a => a.ItemCount);
        var correct = attempts.Sum(a => a.CorrectCount);
        return new ProgressOverview(
            attempts.Count,
            items,
            correct,
            items == 0 ? 0 : 100.0 * correct / items,
            attempts.Select(a => a.SetId).Distinct().Count());
    }

    public async Task<List<TaskStat>> GetTaskStatsAsync(string ownerId)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var rows = await db.Attempts.AsNoTracking()
            .Where(a => a.OwnerId == ownerId && !a.AnswersRevealed)
            .GroupBy(a => a.TaskId)
            .Select(g => new
            {
                TaskId = g.Key,
                Attempts = g.Count(),
                Items = g.Sum(x => x.ItemCount),
                Correct = g.Sum(x => x.CorrectCount),
                Hints = g.Count(x => x.HintUsed),
                Last = g.Max(x => x.TimestampUtc)
            })
            .ToListAsync();

        return rows.Select(r => new TaskStat(
            r.TaskId,
            r.Attempts,
            r.Items,
            r.Correct,
            r.Items == 0 ? 0 : 100.0 * r.Correct / r.Items,
            r.Attempts == 0 ? 0 : 100.0 * r.Hints / r.Attempts,
            r.Last)).OrderBy(t => t.TaskId).ToList();
    }

    /// <summary>Per-day accuracy series, newest last. UTC days are good enough for practice stats.</summary>
    public async Task<List<DailyPoint>> GetDailySeriesAsync(string ownerId, string? taskId, int days)
    {
        var since = DateTime.UtcNow.Date.AddDays(-(days - 1));
        await using var db = await dbFactory.CreateDbContextAsync();
        var query = db.Attempts.AsNoTracking().Where(a => a.OwnerId == ownerId && !a.AnswersRevealed && a.TimestampUtc >= since);
        if (taskId is not null) query = query.Where(a => a.TaskId == taskId);

        var rows = await query
            .GroupBy(a => a.TimestampUtc.Date)
            .Select(g => new { Day = g.Key, Attempts = g.Count(), Items = g.Sum(x => x.ItemCount), Correct = g.Sum(x => x.CorrectCount) })
            .ToListAsync();

        var byDay = rows.ToDictionary(r => r.Day, r => r);
        var series = new List<DailyPoint>();
        for (var day = since; day <= DateTime.UtcNow.Date; day = day.AddDays(1))
        {
            if (byDay.TryGetValue(day, out var r))
                series.Add(new DailyPoint(day, r.Attempts, r.Items, r.Correct, r.Items == 0 ? 0 : 100.0 * r.Correct / r.Items));
        }
        return series;
    }

    public record HistoryRow(long Id, string TaskId, string SetId, int CorrectCount, int ItemCount,
        bool HintUsed, DateTime TimestampUtc);

    public async Task<List<HistoryRow>> GetHistoryAsync(string ownerId, int take = 100)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        return await db.Attempts.AsNoTracking()
            .Where(a => a.OwnerId == ownerId && !a.AnswersRevealed)
            .OrderByDescending(a => a.TimestampUtc)
            .Take(take)
            .Select(a => new HistoryRow(a.Id, a.TaskId, a.SetId, a.CorrectCount, a.ItemCount, a.HintUsed, a.TimestampUtc))
            .ToListAsync();
    }

    /// <summary>Deletes all practice history (attempts, per-gap answers, seen sets) for an owner.</summary>
    public async Task<int> ResetStatsAsync(string ownerId)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var attempts = await db.Attempts.Where(a => a.OwnerId == ownerId).ToListAsync();
        if (attempts.Count > 0)
        {
            var ids = attempts.Select(a => a.Id).ToList();
            await db.GapAnswers.Where(g => ids.Contains(g.AttemptId)).ExecuteDeleteAsync();
            db.Attempts.RemoveRange(attempts);
        }
        var seen = await db.SeenSets.Where(s => s.OwnerId == ownerId).ToListAsync();
        db.SeenSets.RemoveRange(seen);
        await db.SaveChangesAsync();
        return attempts.Count;
    }

    /// <summary>
    /// Per-task momentum: accuracy of the 5 most recent attempts minus the accuracy of
    /// the 5 before them (percentage points; positive = improving). 0 when there is
    /// not enough history to compare.
    /// </summary>
    public async Task<Dictionary<string, double>> GetTaskTrendsAsync(string ownerId)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var attempts = await db.Attempts.AsNoTracking()
            .Where(a => a.OwnerId == ownerId && !a.AnswersRevealed)
            .OrderBy(a => a.TimestampUtc)
            .Select(a => new { a.TaskId, a.CorrectCount, a.ItemCount })
            .ToListAsync();

        static double Accuracy(IEnumerable<(int Correct, int Items)> rows)
        {
            int correct = 0, total = 0;
            foreach (var r in rows) { correct += r.Correct; total += r.Items; }
            return total == 0 ? 0 : 100.0 * correct / total;
        }

        var trends = new Dictionary<string, double>();
        foreach (var g in attempts.GroupBy(a => a.TaskId))
        {
            var rows = g.Select(a => (Correct: a.CorrectCount, Items: a.ItemCount)).ToList();
            var last = rows.TakeLast(5);
            var prev = rows.SkipLast(5).TakeLast(5);
            trends[g.Key] = prev.Any() ? Accuracy(last) - Accuracy(prev) : 0;
        }
        return trends;
    }

    /// <summary>Gaps the owner got wrong most often, per task — the "mistake focus" list.</summary>
    public async Task<List<(string Expected, int Times, string TaskId)>> GetTopMistakesAsync(string ownerId, int take = 20)
    {
        await using var db = await dbFactory.CreateDbContextAsync();
        var rows = await db.GapAnswers.AsNoTracking()
            .Where(g => !g.IsCorrect && !g.Attempt!.AnswersRevealed && g.Attempt.OwnerId == ownerId)
            .GroupBy(g => new { g.Attempt!.TaskId, g.ExpectedAnswer })
            .Select(g => new { g.Key.TaskId, g.Key.ExpectedAnswer, Times = g.Count() })
            .OrderByDescending(x => x.Times)
            .Take(take)
            .ToListAsync();
        return rows.Select(r => (r.ExpectedAnswer, r.Times, r.TaskId)).ToList();
    }
}
