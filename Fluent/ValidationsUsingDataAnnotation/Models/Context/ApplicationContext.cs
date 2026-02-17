using System;
using Microsoft.EntityFrameworkCore;

namespace ValidationsUsingDataAnnotation.Models.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=AppDb;User Id=sa;Password=2004@Nilu;TrustServerCertificate=True;");
        }
    }
}
