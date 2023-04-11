using Microsoft.EntityFrameworkCore;
using DepartmentAPI.Models;

namespace DepartmentAPI.Context;

 public class CollectionContext:DbContext{
    public DbSet<Department> Departments {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString="server=localhost; database=transflower; user=root; password=password";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Department>(entity => 
        {
          entity.HasKey(e => e.Id);
          entity.Property(e => e.Name).IsRequired();
          entity.Property(e => e.Location).IsRequired();
        });
    }
}