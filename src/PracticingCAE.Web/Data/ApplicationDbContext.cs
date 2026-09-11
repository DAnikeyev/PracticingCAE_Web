using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PracticingCAE.Web.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<AttemptRecord> Attempts => Set<AttemptRecord>();
    public DbSet<GapAnswerRecord> GapAnswers => Set<GapAnswerRecord>();
    public DbSet<SeenSetRecord> SeenSets => Set<SeenSetRecord>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<AttemptRecord>(e =>
        {
            e.HasIndex(a => new { a.OwnerId, a.TaskId, a.TimestampUtc });
            e.HasMany(a => a.Gaps).WithOne(g => g.Attempt!).HasForeignKey(g => g.AttemptId);
        });
        builder.Entity<SeenSetRecord>(e =>
        {
            e.HasIndex(s => new { s.OwnerId, s.TaskId, s.SetId }).IsUnique();
        });
    }
}
