using System.Data.Common;

class Student
{
  public string Name { get; set; }
  public int Age { get; set; }
}
class anyNomousNew
{
  delegate bool IsTeenager(Student s);
  public static void anynomousNew()
  {
    Student student = new Student()
    {
      Name = "Rahul",
      Age = 20
    };

    IsTeenager teen = delegate (Student s)
    {
      return (s.Age > 13 && s.Age < 20); //anonymous method
    };
    // Lambda Expression
    IsTeenager teenLambde = (s) => (s.Age > 13 && s.Age < 20);
    IsTeenager teenLambda2 = s => s.Age > 13 && s.Age < 20;

    bool teenager = teen(student);
    Console.WriteLine(teenager);
    Console.WriteLine(teenLambde(student));
    Console.WriteLine(teenLambda2(student));

  }
}