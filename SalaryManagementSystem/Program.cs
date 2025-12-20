// See https://aka.ms/new-console-template for more information
class Program
{
  static void Main(string[] args)
  {
    // Employee emp = new Employee();
    // CalculateSalary calcSalary = new CalculateSalary();
    // calcSalary.SetEmployeeDetails(emp, 101, "John Doe", 50000);
    // int netSalary = calcSalary.CalculateNetSalary(emp);
    // Console.WriteLine("Net Salary of " + emp.Ename + " (Employee No: " + emp.Eno + ") is: " + netSalary);
    DistributedMarkManagement student = new DistributedMarkManagement();
    student.ReadStudentDetails();
    student.CalculateResult();
  }
}
