using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Course Class
    // =========================
    public class Course
    {
        public string CourseCode { get; private set; }
        public string CourseName { get; private set; }
        public int Credits { get; private set; }
        public int MaxCapacity { get; private set; }
        public List<string> Prerequisites { get; private set; }

        private int CurrentEnrollment;

        public Course(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            CourseCode = code;
            CourseName = name;
            Credits = credits;
            MaxCapacity = maxCapacity;
            Prerequisites = prerequisites ?? new List<string>();
            CurrentEnrollment = 0;
        }

        public bool IsFull()
        {
            // TODO: Return true if CurrentEnrollment >= MaxCapacity
            // Completed: check whether the current enrollment has reached or exceeded the maximum capacity.
            return CurrentEnrollment >= MaxCapacity;
        }

        public bool HasPrerequisites(List<string> completedCourses)
        {
            // TODO: Check if ALL prerequisites exist in completedCourses
            // Completed:
            // - If there are no prerequisites, the requirement is automatically satisfied.
            // - Otherwise, ensure every prerequisite is present in the student's completed courses.
            if (Prerequisites == null || Prerequisites.Count == 0)
            {
                return true;
            }

            if (completedCourses == null)
            {
                return false;
            }

            return Prerequisites.All(prereq => completedCourses.Contains(prereq));
        }

        public void EnrollStudent()
        {
            // TODO:
            // 1. Throw InvalidOperationException if course is full
            // 2. Otherwise increment CurrentEnrollment
            // Completed:
            if (IsFull())
            {
                throw new InvalidOperationException("Cannot enroll student: course is full.");
            }

            CurrentEnrollment++;
        }

        public void DropStudent()
        {
            // TODO: Decrement CurrentEnrollment only if greater than zero
            // Completed: avoid negative enrollment counts.
            if (CurrentEnrollment > 0)
            {
                CurrentEnrollment--;
            }
        }

        public string GetEnrollmentInfo()
        {
            return $"{CurrentEnrollment}/{MaxCapacity}";
        }
    }
}
