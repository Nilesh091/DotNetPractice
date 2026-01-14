
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Assignment_BoilerPlateCode.Repos;
using LINQ_Assignment_BoilerPlateCode.DTOs;
using LINQ_Assignment_BoilerPlateCode.Models;
using System.Collections.Specialized;

namespace LINQ_Assignment_BoilerPlateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // =======================
            // SAMPLE DATA
            // =======================
            var employees = EmployeeRepo.SeedEmployees();
            var projects = ProjectRepo.SeedProjects();


            var highEarners = GetHighEarningEmployees(employees);
            Console.WriteLine("\nEmployees earning more than 60,000:");
            foreach (var e in highEarners)
                Console.WriteLine($"{e.Id}  {e.Name}  {e.Department}  {e.Salary}");

            var names = GetEmployeeNames(employees);
            Console.WriteLine("\nEmployee Names:");
            foreach (var n in names)
                Console.WriteLine(n);
            bool hasHR = HasHREmployees(employees);
            Console.WriteLine("\nAny HR Employees? : " + hasHR);

            var deptCounts = GetDepartmentWiseCount(employees);
            Console.WriteLine("\nDepartment Wise Count:");
            foreach (var d in deptCounts)
                Console.WriteLine($"{d.Department} : {d.Count}");

            var highest = GetHighestPaidEmployee(employees);
            Console.WriteLine("\nHighest Paid Employee:");
            Console.WriteLine($"{highest.Id}  {highest.Name}  {highest.Department}  {highest.Salary}");

            var sorted = SortEmployeesBySalaryAndName(employees);
            Console.WriteLine("\nSorted Employees (Salary DESC, Name ASC):");
            foreach (var e in sorted)
                Console.WriteLine($"{e.Name}  {e.Department}  {e.Salary}");


            Console.WriteLine("LINQ Scenario Boilerplate Loaded");
        }

        // =====================================================
        // 🟢 SECTION 1 – HR ANALYTICS
        // =====================================================

        // TODO 1.1: Get employees earning more than 60,000
        static List<Employee> GetHighEarningEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            List<Employee> ans = employees.Where(emp => emp.Salary > 6000).ToList();
            return ans;
        }

        // TODO 1.2: Get list of employee names only
        static List<string> GetEmployeeNames(List<Employee> employees)
        {
            List<string> ans = employees.Select((s) => s.Name).ToList();
            return ans;
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 1.3: Check if any employee belongs to HR department
        static bool HasHREmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.Any(s => s.Department == "HR");
            throw new NotImplementedException();
        }

        // =====================================================
        // 🟡 SECTION 2 – MANAGEMENT INSIGHTS
        // =====================================================

        // TODO 2.1: Get department-wise employee count
        static List<DepartmentCount> GetDepartmentWiseCount(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.GroupBy(s => s.Department).Select(g => new DepartmentCount { Department = g.Key, Count = g.Count() }).ToList();
            throw new NotImplementedException();
        }

        // TODO 2.2: Find the highest paid employee
        static Employee GetHighestPaidEmployee(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.OrderByDescending(s => s.Salary).FirstOrDefault();
            throw new NotImplementedException();
        }

        // TODO 2.3: Sort employees by Salary (DESC), then Name (ASC)
        static List<Employee> SortEmployeesBySalaryAndName(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            return employees.OrderByDescending(s => s.Salary).ThenBy(s => s.Name).ToList();
            throw new NotImplementedException();
        }

        // =====================================================
        // 🔵 SECTION 3 – PROJECT & SKILL INTELLIGENCE
        // =====================================================

        // TODO 3.1: Join employees with projects
        static List<EmployeeProject> GetEmployeeProjectMappings(
            List<Employee> employees,
            List<Project> projects)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 3.2: Find employees who are NOT assigned to any project
        static List<Employee> GetUnassignedEmployees(
            List<Employee> employees,
            List<Project> projects)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 3.3: Get all unique skills across the organization
        static List<string> GetAllUniqueSkills(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // =====================================================
        // 🔴 SECTION 4 – ADVANCED WORKFORCE ANALYTICS
        // =====================================================

        // TODO 4.1: Get top 3 highest-paid employees per department
        static List<DepartmentTopEmployees> GetTopEarnersByDepartment(
            List<Employee> employees)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 4.2: Remove duplicate employees based on Id
        static List<Employee> RemoveDuplicateEmployees(List<Employee> employees)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }

        // TODO 4.3: Implement pagination
        static List<Employee> GetEmployeesByPage(
            List<Employee> employees,
            int pageNumber,
            int pageSize = 5)
        {
            // TODO: Write LINQ query here
            throw new NotImplementedException();
        }


    }
}
