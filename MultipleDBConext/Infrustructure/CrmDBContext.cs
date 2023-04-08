using Core.Models.CrmSchema;

using Microsoft.EntityFrameworkCore;

namespace Infrustructure;


/// <summary>
///  In Visual Studio: 
///  Add-Migration 
/// </summary>
public class CrmDBContext : DbContext
{


    public CrmDBContext(DbContextOptions<CrmDBContext> options) : base(options)
    {

    }

    public DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema("crm");
    }
}