using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
    // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter course code: ");
                            string cCode = Console.ReadLine();
                            Console.Write("Enter course name: ");
                            string cName = Console.ReadLine();
                            Console.Write("Enter course credits: ");
                            int cCredits = int.Parse(Console.ReadLine());
                            Console.Write("Enter max capacity (default 50): ");
                            string capInput = Console.ReadLine();
                            int maxCap = int.Parse(capInput);
                            Console.Write("Enter prerequisites (comma-separated course codes, or leave blank): ");
                            string prereqInput = Console.ReadLine();
                            List<string> prereqs = null;
                            if (!string.IsNullOrWhiteSpace(prereqInput))
                            {
                                prereqs = prereqInput.Split(',').Select(p => p.Trim()).Where(p => p.Length > 0).ToList();
                            }
                            system.AddCourse(cCode, cName, cCredits, maxCap, prereqs);
                            Console.WriteLine("Course added successfully.");
                            break;

                        case "2":
                            Console.Write("Enter student ID: ");
                            string sId = Console.ReadLine();
                            Console.Write("Enter student name: ");
                            string sName = Console.ReadLine();
                            Console.Write("Enter major: ");
                            string major = Console.ReadLine();
                            Console.Write("Enter max credits (default 18): ");
                            string maxCrInput = Console.ReadLine();
                            int maxCr = int.Parse(maxCrInput);
                            Console.Write("Enter completed courses (comma-separated course codes, or leave blank): ");
                            string completedInput = Console.ReadLine();
                            List<string> completed = null;

                            completed = completedInput.Split(',');

                            system.AddStudent(sId, sName, major, maxCr, completed);
                            Console.WriteLine("Student added successfully.");
                            break;

                        case "3":
                            Console.Write("Enter student ID: ");
                            string regSid = Console.ReadLine();
                            Console.Write("Enter course code: ");
                            string regCcode = Console.ReadLine();
                            system.RegisterStudentForCourse(regSid, regCcode);
                            break;

                        case "4":
                            Console.Write("Enter student ID: ");
                            string dropSid = Console.ReadLine();
                            Console.Write("Enter course code: ");
                            string dropCcode = Console.ReadLine();
                            system.DropStudentFromCourse(dropSid, dropCcode);
                            break;

                        case "5":
                            system.DisplayAllCourses();
                            break;

                        case "6":
                            Console.Write("Enter student ID: ");
                            string schedSid = Console.ReadLine();
                            system.DisplayStudentSchedule(schedSid);
                            break;

                        case "7":
                            system.DisplaySystemSummary();
                            break;

                        case "8":
                            exit = true;
                            Console.WriteLine("Exiting system. Goodbye.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

