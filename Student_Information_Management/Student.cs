using System.Data;

public class Student
{
  public string name;
  public int age;
  public string grade;
  public Student()
  {
    name = "Hallen Doe";
    age = 21;
    grade = "A";
  }
  public Student(string name, int age, string grade)
  {
    this.name = name;
    this.age = age;
    this.grade = grade;
  }
}