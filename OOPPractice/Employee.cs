using System;
using System.Runtime.CompilerServices;

class Employee
{
  private int employeeId = 0;
  private string name = string.Empty;
  private string department = string.Empty;
  private float salary = 0.0f;
  private bool status = true;

  public void SetEmployeeDetails()
  {
    Console.WriteLine("Enter Employee ID:");
    employeeId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Employee Name:");
    name = Console.ReadLine();
    Console.WriteLine("Enter Employee Department:");
    department = Console.ReadLine();
    Console.WriteLine("Enter Employee Salary:");
    salary = float.Parse(Console.ReadLine());
    Console.WriteLine("Is Employee Active?(true/false):");
    status = Boolean.Parse(Console.ReadLine());

  }
  public void GetEmployeeDetails()
  {
    Console.WriteLine("Employee ID: " + employeeId);
    Console.WriteLine("Employee Name: " + name);
    Console.WriteLine("Employee Department: " + department);
    Console.WriteLine("Employee Salary: " + salary);
    Console.WriteLine("Employee Active Status: " + status);
  }

}