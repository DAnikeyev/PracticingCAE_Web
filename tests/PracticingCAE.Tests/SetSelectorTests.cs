using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using PracticingCAE.Web.Data;
using PracticingCAE.Web.Services;
using Xunit;

namespace PracticingCAE.Tests;

public class SetSelectorTests : IDisposable
{
    private readonly SqliteConnection _connection;
    private readonly ApplicationDbContext _db;
    private readonly ContentRepository _repo = new(NullLogger<ContentRepository>.Instance);
    private readonly SetSelector _selector;

    public SetSelectorTests()
    {
        _connection = new SqliteConnection("DataSource=:memory:");
        _connection.Open();
        _db = new ApplicationDbContext(
            new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(_connection).Options);
        _db.Database.EnsureCreated();
        var factory = new DbContextFactoryStub(_connection);
        _selector = new SetSelector(factory, _repo);
    }

    [Fact]
    public async Task NextSet_PrioritisesUnseenSets()
    {
        var seen = new HashSet<string>();
        for (var i = 0; i < 12; i++)
        {
            var set = await _selector.NextSetAsync("owner-a", "rue-part1");
            Assert.NotNull(set);
            Assert.DoesNotContain(set!.Id, seen); // always fresh while unseen sets remain
            seen.Add(set.Id);
        }
    }

    [Fact]
    public async Task NextSet_IsPerOwner()
    {
        var forA = await _selector.NextSetAsync("owner-a", "articles");
        var forB = await _selector.NextSetAsync("owner-b", "articles");
        Assert.NotNull(forA);
        Assert.NotNull(forB);
        // owner B must still be served unseen sets even though owner A has seen one
        Assert.NotEqual(forA!.Id, forB!.Id);
    }

    [Fact]
    public async Task NextSet_RecordsSeenSets()
    {
        var set = await _selector.NextSetAsync("owner-a", "articles");
        Assert.NotNull(set);
        var rec = await _db.SeenSets.SingleAsync(s => s.OwnerId == "owner-a" && s.TaskId == "articles");
        Assert.Equal(set!.Id, rec.SetId);
        Assert.Equal(1, rec.TimesSeen);
    }

    [Fact]
    public async Task NextSet_ReturnsNullForUnknownTask()
    {
        var set = await _selector.NextSetAsync("owner-a", "no-such-task");
        Assert.Null(set);
    }

    [Fact]
    public async Task RepeatedDraws_AreMostlyDistinctAndRecorded()
    {
        var seenOrder = new List<string>();
        for (var i = 0; i < 5; i++)
        {
            var set = await _selector.NextSetAsync("owner-c", "articles");
            seenOrder.Add(set!.Id);
        }
        var distinct = seenOrder.Distinct().Count();
        Assert.True(distinct >= 4, $"expected mostly-distinct draws, got {distinct}");
        var seenRows = await _db.SeenSets.CountAsync(s => s.OwnerId == "owner-c");
        Assert.Equal(distinct, seenRows);
    }

    public void Dispose()
    {
        _db.Dispose();
        _connection.Dispose();
    }

    /// <summary>IDbContextFactory that reuses one open in-memory connection.</summary>
    private sealed class DbContextFactoryStub(SqliteConnection connection)
        : IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext()
        {
            return new ApplicationDbContext(
                new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(connection).Options);
        }

        public Task<ApplicationDbContext> CreateDbContextAsync(CancellationToken cancellationToken = default)
            => Task.FromResult(CreateDbContext());
    }
}
