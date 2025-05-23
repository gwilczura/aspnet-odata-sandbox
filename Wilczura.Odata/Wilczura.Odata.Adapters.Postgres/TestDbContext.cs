using Microsoft.EntityFrameworkCore;
using Wilczura.Odata.Adapters.Postgres.Entities;

namespace Wilczura.Odata.Adapters.Postgres;

public class TestDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.HasPostgresExtension("citext");
    }
}
