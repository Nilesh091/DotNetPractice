class Employee : IComparable<Employee>
{
  public int Id { get; set; }
  public string Name { get; set; }

  public int CompareTo(Employee other)
  {
    return this.Id.CompareTo(other.Id);
  }
}
class ComparablesInCsharp
{
  public static void AccessObject()
  {
    Employee[] employees = new Employee[3];
    employees[0] = new Employee
    {
      Id = 3,
      Name = "Nilu"
    };
    employees[1] = new Employee
    {
      Id = 2,
      Name = "Njhhan"
    };
    employees[2] = new Employee
    {
      Id = 1,
      Name = "qwerty"
    };
    PrintEmployees(employees);
    Console.WriteLine("\nAfter Sorting by ID:\n");
    Array.Sort(employees);//Sorting the Objects using Comparable Interface
    PrintEmployees(employees);

  }

  public static void PrintEmployees(Employee[] arr)
  {
    foreach (Employee e in arr)
    {
      Console.WriteLine($"Id: {e.Id} Name: {e.Name}");
    }
  }
}