using System;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace ValidationsUsingDataAnnotation.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
