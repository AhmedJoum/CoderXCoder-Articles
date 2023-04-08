using Core.Models.HrSchema;

using Microsoft.EntityFrameworkCore;

namespace Infrustructure;

public class HrDBContext : DbContext
{
    public HrDBContext(DbContextOptions<HrDBContext> options) : base(options)
    { }

    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("hr");
    }
}
