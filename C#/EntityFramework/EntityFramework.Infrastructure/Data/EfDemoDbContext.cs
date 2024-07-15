using EntityFramework.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EntityFramework.Infrastructure.Data;

public class EfDemoDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var conn = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build().GetConnectionString("EfDemoDb");

        optionsBuilder.UseSqlServer(conn);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.DepartmentName).HasColumnType("varchar(20)");
            entity.HasKey(e => e.Id);
            entity.HasIndex(e => e.DepartmentName).IsUnique();
        });
    }
}