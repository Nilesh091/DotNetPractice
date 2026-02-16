using System;
using Microsoft.EntityFrameworkCore;

namespace Fluent_Api_Demo.Model.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=SchoolDatabase;User Id=sa;Password=2004@Nilu;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SchoolContext).Assembly);
            // modelBuilder.Entity<Student>().HasKey(s => s.Id); //Configuring Primary Key

            // modelBuilder.Entity<Student>().Property(s => s.Name).IsRequired();
            // modelBuilder.Entity<Student>().Property(s => s.Name).HasMaxLength(35);

        }
        // protected override void On


    }
}
