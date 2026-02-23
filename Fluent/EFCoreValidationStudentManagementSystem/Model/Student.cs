using System;
using System.ComponentModel.DataAnnotations;

namespace EFCoreValidationStudentManagementSystem.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Range(18, 60)]
        public int Age { get; set; }
        [FutureDataValidateion]
        public DateTime EnrollmentDate { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
