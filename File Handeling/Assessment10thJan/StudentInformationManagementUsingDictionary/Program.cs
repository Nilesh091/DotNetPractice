using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Student
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Grade { get; set; }
}

class StudentManager
{
  public Dictionary<int, Student> Students { get; set; }

  public StudentManager()
  {
    Students = new Dictionary<int, Student>();
  }
  public void AddStudent(Student st)
  {
    Students[st.Id] = st;
  }

  public void DisplayStudents()
  {
    foreach (var v in Students)
    {
      Student student = v.Value;
      Console.WriteLine("Id : " + student.Id + " Name : " + student.Name + " Grade : " + student.Grade);
    }
  }
}
class Program
{
  public static void Main()
  {
    StudentManager sm = new StudentManager();
    Console.WriteLine("Enter the number of students you want to add:");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine("Enter Id: ");
      int id = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter name: ");
      string name = Console.ReadLine();
      Console.WriteLine("Enter Grade:");
      string grade = Console.ReadLine();
      Student st = new Student()
      {
        Id = id,
        Name = name,
        Grade = grade
      };
      sm.AddStudent(st);
    }
    sm.DisplayStudents();

  }
}