using System.Data;

class Student
{
  public int Id { get; set; }
  public String Name { get; set; }
}
class Program
{
  public static void Main()
  {
    // string[] s = { "Nilu", "Yash", "Lokhande", "Shivam", "Sikha", "Satvik", "Nikita" };
    // //Query Syntax
    // var filteredNames = from name in s where name.Contains('a') select name;
    // //Method Syntax
    // var v = s.Where(name => name.Contains('S'));

    // foreach (var name in filteredNames)
    // {
    //   Console.WriteLine(name);
    // }
    // Console.WriteLine("++++++++==========++++++++=======++++++++=====+++++++=====+++++");
    // foreach (var name in v)
    // {
    //   Console.WriteLine(name);
    // }

    // IList<Student> listStudent = new List<Student>()
    // {
    //   new Student{ Id=1,Name="Nilu"},
    //   new Student{Id=2,Name="Yash"},
    //   new Student{Id=3,Name="Lokhande"},
    //   new Student{Id=4,Name="Vansikha"},
    //   new Student{Id=3,Name="Shivam"},
    //   new Student{Id=3,Name="Niki"}
    // };
    // Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    // //Query
    // var filteredQuery = from li in listStudent where li.Name.Contains('a') select li;
    // var filterMethod = listStudent.Where(st => st.Name.Contains('s'));

    // foreach (var name in filteredQuery)
    // {
    //   Console.WriteLine(name.Name);
    // }
    // Console.WriteLine("+++++++++++++======+++====++====++===+==++===+==++=========+++++++++=======");
    // foreach (var name in filterMethod)
    // {
    //   Console.WriteLine(name.Name);
    // }


    Employee emp = new Employee();
    emp.Rows.Add(1, "John", 30, "IT", 5000);
    emp.Rows.Add(2, "Amit", 28, "HR", 4200);
    emp.Rows.Add(3, "Neha", 26, "Finance", 4800);
    emp.Rows.Add(4, "Rahul", 32, "IT", 6000);
    emp.Rows.Add(5, "Priya", 29, "Marketing", 4500);
    emp.Rows.Add(6, "Suresh", 35, "Admin", 5200);
    emp.Rows.Add(7, "Anita", 27, "HR", 4300);
    emp.Rows.Add(8, "Vikas", 34, "Finance", 6100);
    emp.Rows.Add(9, "Kiran", 31, "Support", 3900);
    emp.Rows.Add(10, "Rohit", 33, "IT", 5800);


    var departmantItSalaryDesc = from it in emp.AsEnumerable()
                                 where it.Field<string>("Department") == "IT"
                                 orderby it.Field<int>("Salary") descending
                                 select it;
    var departmantItSalaryDesc1 = emp.AsEnumerable().Where(s => s.Field<string>("Department") == "Finance").OrderByDescending(s => s.Field<int>("Salary"));

    foreach (DataRow row in departmantItSalaryDesc)
    {
      Console.WriteLine(
          $"Id: {row.Field<int>("Id")}  " +
          $"Name: {row.Field<string>("Name")}  " +
          $"Dept: {row.Field<string>("Department")}  " +
          $"Salary: {row.Field<int>("Salary")}"
      );
    }

  }




}