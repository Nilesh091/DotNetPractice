using Entity_Framework_Demo_adding_database_with_database_first_approach.Models;

class Program
{
  public static void Main()
  {
    AdventureWorksContext context = new AdventureWorksContext();
    var query = context.Employees.ToList();
    foreach (Employee e in query)
    {
      Console.WriteLine($"Employee Id: {e.EmployeeId} National Id: {e.NationalIdnumber} ");
    }
  }
}