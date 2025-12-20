// See https://aka.ms/new-console-template for more information
class Program
{
  static void Main(string[] args)
  {
    Employee emp = new Employee();// Creating object of Employee class
    emp.SetEmployeeDetails();// Method to set employee details
    emp.GetEmployeeDetails();// Method to get employee details
    Console.ReadKey(); // To hold the console screen
  }
}