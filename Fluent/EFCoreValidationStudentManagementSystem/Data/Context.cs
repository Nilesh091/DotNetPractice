using System;
using EFCoreValidationStudentManagementSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreValidationStudentManagementSystem.Data
{
    public class Context : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=AppDb1;User Id=sa;Password=2004@Nilu;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasIndex(s => s.Email).IsUnique();
            modelBuilder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Course>().HasMany(c => c.Students).WithOne(s => s.Course).HasForeignKey(s => s.CourseId);
        }


    }
}
