using System;
using System.ComponentModel.DataAnnotations;

namespace ValidationsUsingDataAnnotation.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
