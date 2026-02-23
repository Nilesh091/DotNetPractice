using System;

namespace EFCoreValidationStudentManagementSystem.Model
{
    public class Course
    {

        public int CourseId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
