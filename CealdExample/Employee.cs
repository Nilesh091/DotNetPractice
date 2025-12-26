public class Employee
{
  protected int id;
  protected string name;
  protected string address;
  protected int age
  ;

  public virtual void GetEmployeeDetails()
  {
    Console.WriteLine("Enter Employee ID: ");
    id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Employee Name: ");
    name = Console.ReadLine();
    Console.WriteLine("Enter Employee Address: ");
    address = Console.ReadLine();
    Console.WriteLine("Enter Employee Age: ");
    age = Convert.ToInt32(Console.ReadLine());

  }

  public virtual void DisplayEmployeeDetails()
  {
    Console.WriteLine("Employee ID: " + id);
    Console.WriteLine("Employee Name: " + name);
    Console.WriteLine("Employee Address: " + address);
    Console.WriteLine("Employee Age: " + age);
    Console.WriteLine();
  }
}