class Manager : Employee
{
  double bonus, CA;
  public override void GetEmployeeDetails()
  {
    Console.WriteLine("Enter Manager Details:");
    Console.WriteLine("Enter Manager Id:");
    id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Manager Name: ");
    name = Console.ReadLine();
    Console.WriteLine("Enter Manager Bonus: ");
    bonus = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Manager CA: ");
    CA = Convert.ToDouble(Console.ReadLine());
  }
  public override void DisplayEmployeeDetails()
  {
    Console.WriteLine("Manager Details:");
    Console.WriteLine("Manager Id: " + id);
    Console.WriteLine("Manager Name: " + name);
    Console.WriteLine("Manager Bonus: " + bonus);
    Console.WriteLine("Manager CA: " + CA);
    Console.WriteLine();
  }

}