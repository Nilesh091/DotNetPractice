using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            if (AvailableCourses.ContainsKey(code))
            {
                throw new ArgumentException("A course with this code already exists.");
            }

            Course course = new Course(code, name, credits, maxCapacity, prerequisites);
            AvailableCourses.Add(code, course);
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            if (Students.ContainsKey(id))
            {
                throw new ArgumentException("A student with this ID already exists.");
            }

            Student student = new Student(id, name, major, maxCredits, completedCourses);
            Students.Add(id, student);
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return false;
            }

            if (!AvailableCourses.ContainsKey(courseCode))
            {
                Console.WriteLine("Course not found.");
                return false;
            }

            Student student = Students[studentId];
            Course course = AvailableCourses[courseCode];

            if (course.IsFull())
            {
                Console.WriteLine("Cannot register: course is already full.");
                return false;
            }

            bool added = student.AddCourse(course);
            if (added)
            {
                Console.WriteLine("Student registered for course successfully.");
            }
            else
            {
                Console.WriteLine("Unable to register student for course. Check prerequisites or credit limit.");
            }

            return added;
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return false;
            }

            Student student = Students[studentId];
            bool dropped = student.DropCourse(courseCode);

            if (dropped)
            {
                Console.WriteLine("Course dropped successfully.");
            }
            else
            {
                Console.WriteLine("Course not found in student's schedule.");
            }

            return dropped;
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            if (AvailableCourses.Count == 0)
            {
                Console.WriteLine("No courses available.");
                return;
            }

            foreach (var kvp in AvailableCourses)
            {
                Course c = kvp.Value;
                Console.WriteLine($"Code: {c.CourseCode}, Name: {c.CourseName}, Credits: {c.Credits}, Enrollment: {c.GetEnrollmentInfo()}");
            }
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            // Call student.DisplaySchedule()
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Student student = Students[studentId];
            Console.WriteLine($"\nSchedule for {student.Name} ({student.StudentId}):");
            student.DisplaySchedule();
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
            int totalStudents = Students.Count;
            int totalCourses = AvailableCourses.Count;

            int totalEnrollment = 0;
            foreach (var c in AvailableCourses.Values)
            {
                // Parse CurrentEnrollment from "current/max" string
                string info = c.GetEnrollmentInfo();
                var parts = info.Split('/');
                int current;
                if (parts.Length > 0 && int.TryParse(parts[0], out current))
                {
                    totalEnrollment += current;
                }
            }

            double averageEnrollment = totalCourses > 0 ? (double)totalEnrollment / totalCourses : 0.0;

            Console.WriteLine("\n===== System Summary =====");
            Console.WriteLine($"Total Students: {totalStudents}");
            Console.WriteLine($"Total Courses: {totalCourses}");
            Console.WriteLine($"Average Enrollment per Course: {averageEnrollment:F2}");
        }
    }
}
