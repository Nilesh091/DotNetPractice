using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            int credit = 0;
            // TODO: Return sum of credits of all RegisteredCourses
            foreach (var v in RegisteredCourses)
            {
                credit += v.Credits;
            }
            return credit;
        }

        public bool CanAddCourse(Course course)
        {
            // TODO:
            // 1. Course should not already be registered
            // 2. Total credits + course credits <= MaxCredits
            // 3. Course prerequisites must be satisfied
            if (!RegisteredCourses.Contains(course) && this.GetTotalCredits() + course.Credits <= MaxCredits && course.HasPrerequisites(CompletedCourses) == true)
            {
                return true;
            }
            return false;
        }

        public bool AddCourse(Course course)
        {
            // TODO:
            // 1. Call CanAddCourse
            // 2. Check course capacity
            // 3. Add course to RegisteredCourses
            // 4. Call course.EnrollStudent()

            if (course == null)
            {
                return false;
            }

            if (!CanAddCourse(course))
            {
                return false;
            }

            if (course.IsFull())
            {
                return false;
            }

            RegisteredCourses.Add(course);
            course.EnrollStudent();
            return true;
        }

        public bool DropCourse(string courseCode)
        {
            // TODO:
            // 1. Find course by code
            //var course=RegisteredCourses.FirstOrDefault(n=> n.CourseCode==courseCode);
            Course course = null;
            foreach (var v in RegisteredCourses)
            {
                if (v.CourseCode == courseCode)
                {
                    course = v;
                    break;
                }
            }
            if (course != null)
            {
                RegisteredCourses.Remove(course);
                // 2. Remove from RegisteredCourses
                // 3. Call course.DropStudent()
                course.DropStudent();
                return true;
            }
            return false;
        }

        public void DisplaySchedule()
        {
            // TODO:
            // Display course code, name, and credits
            if (RegisteredCourses.Count != 0)
            {
                foreach (var v in RegisteredCourses)
                {
                    Console.WriteLine("Course code: " + v.CourseCode + " Name: " + v.CourseName + " Credit : " + v.Credits);
                }
            }
            else
            {
                Console.WriteLine("No course registered yet.");
            }
            // If no courses registered, display appropriate message
        }
    }
}
