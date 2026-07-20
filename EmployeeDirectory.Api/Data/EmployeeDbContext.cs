using EmployeeDirectory.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDirectory.Api.Data;

public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(
        DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees => Set<Employee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>()
            .HasData(SeedData.Employees);
    }
}
