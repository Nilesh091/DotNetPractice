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


    }
}
