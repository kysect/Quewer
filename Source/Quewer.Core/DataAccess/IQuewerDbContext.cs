using Microsoft.EntityFrameworkCore;
using Quewer.Core.Models;

namespace Quewer.Core.DataAccess;

public interface IQuewerDbContext
{
    DbSet<Que> Ques { get; set; }
    DbSet<Queam> Queams { get; set; }
    DbSet<QueamQueser> QueamQuesers { get; set; }
    DbSet<QueQueamQueser> QueQueamQuesers { get; set; }
    DbSet<Queser> Quesers { get; set; }
}

public class QuewerDbContext : DbContext, IQuewerDbContext
{
    public QuewerDbContext(DbContextOptions<QuewerDbContext> options) : base(options)
    {
    }

    public DbSet<Que> Ques { get; set; }
    public DbSet<Queam> Queams { get; set; }
    public DbSet<QueamQueser> QueamQuesers { get; set; }
    public DbSet<QueQueamQueser> QueQueamQuesers { get; set; }
    public DbSet<Queser> Quesers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<QueQueamQueser>().HasKey(q => new { q.QueId, q.QueamQueserId });

        base.OnModelCreating(modelBuilder);
    }
}
