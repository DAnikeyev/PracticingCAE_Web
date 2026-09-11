using Microsoft.EntityFrameworkCore;
using PracticingCAE.Web.Data;

namespace PracticingCAE.Web.Services;

/// <summary>
/// Picks the next practice set for an owner, prioritising sets they have never seen.
/// Once everything has been seen, the least-recently-seen sets come back first.
/// </summary>
public sealed class SetSelector(
    IDbContextFactory<ApplicationDbContext> dbFactory,
    ContentRepository content)
{
    public Task<PracticeSet?> NextSetAsync(string ownerId, TaskDef task) =>
        NextSetAsync(ownerId, task.Id);

    public async Task<PracticeSet?> NextSetAsync(string ownerId, string taskId)
    {
        var all = content.SetsFor(taskId);
        if (all.Count == 0) return null;

        await using var db = await dbFactory.CreateDbContextAsync();
        var seen = await db.SeenSets
            .Where(s => s.OwnerId == ownerId && s.TaskId == taskId)
            .ToDictionaryAsync(s => s.SetId, s => s);

        PracticeSet chosen;
        var unseen = all.Where(s => !seen.ContainsKey(s.Id)).ToList();
        if (unseen.Count > 0)
        {
            chosen = unseen[Random.Shared.Next(unseen.Count)];
        }
        else
        {
            var oldest = seen.Values.MinBy(s => s.LastSeenUtc)?.LastSeenUtc ?? DateTime.UtcNow;
            var candidates = all
                .Where(s => seen.TryGetValue(s.Id, out var rec) && rec.LastSeenUtc == oldest)
                .ToList();
            chosen = (candidates.Count > 0 ? candidates : all)[Random.Shared.Next(candidates.Count > 0 ? candidates.Count : all.Count)];
        }

        await MarkSeenAsync(db, ownerId, taskId, chosen.Id);
        return chosen;
    }

    private static async Task MarkSeenAsync(Data.ApplicationDbContext db, string ownerId, string taskId, string setId)
    {
        var now = DateTime.UtcNow;
        var rec = await db.SeenSets.FirstOrDefaultAsync(s =>
            s.OwnerId == ownerId && s.TaskId == taskId && s.SetId == setId);
        if (rec is null)
        {
            db.SeenSets.Add(new SeenSetRecord
            {
                OwnerId = ownerId,
                TaskId = taskId,
                SetId = setId,
                TimesSeen = 1,
                LastSeenUtc = now
            });
        }
        else
        {
            rec.TimesSeen++;
            rec.LastSeenUtc = now;
        }
        await db.SaveChangesAsync();
    }
}
