using System;
using Microsoft.EntityFrameworkCore;

namespace EfPracticeCodeFirstApproach.Model.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student>? Students { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Branch>? Branches { get; set; }
        public DbSet<Address>? Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=SchoolDb;User Id=sa;Password=2004@Nilu;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "Rahul Sharma",
                    Email = "rahul@gmail.com",
                    BranchId = 101,
                    Phone = "9876543210"
                },
                new Student
                {
                    Id = 2,
                    Name = "Anita Verma",
                    Email = "anita@gmail.com",
                    BranchId = 102,
                    Phone = "9123456780"
                },
                new Student
                {
                    Id = 3,
                    Name = "Vikram Singh",
                    Email = "vikram@gmail.com",
                    BranchId = 103,
                    Phone = "9012345678"
                }

            );

            modelBuilder.Entity<Branch>().HasData(
                new Branch
                {
                    Id = 1,
                    Name = "Compute Science"
                },
                new Branch
                {
                    Id = 2,
                    Name = "Mechanical"
                },
                new Branch
                {
                    Id = 3,
                    Name = "Electrical"
                }
            );
            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    StudentId = 1,
                    City = "Hydrabad",
                    State = "Telengana",
                    Country = "India",
                    Pin = "123456"
                },
                new Address
                {
                    Id = 2,
                    StudentId = 2,
                    City = "Banglore",
                    State = "Karnataka",
                    Country = "India",
                    Pin = "123457"
                },
                new Address
                {
                    Id = 3,
                    StudentId = 3,
                    City = "Bhubaneswar",
                    State = "Odisha",
                    Country = "India",
                    Pin = "123452"
                }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 326,
                    CourseName = "Operation System"
                },
                new Course
                {
                    CourseId = 336,
                    CourseName = "Computer Networks"
                },
                new Course
                {
                    CourseId = 312,
                    CourseName = "Autometa"
                }
            );
        }
    }
}
