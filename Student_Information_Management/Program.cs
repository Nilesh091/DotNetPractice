// See https://aka.ms/new-console-template for more information
using System;
class Program
{
  public static void Main(string[] args)
  {
    Student st = new Student();
    //Default constructor/Basic Constrictor is called

    Console.WriteLine(st.name);
    Console.WriteLine(st.age);
    Console.WriteLine(st.grade);
    //Calling Parameterized constructor
    Student st1 = new Student("John Doe", 22, "B");
    Console.WriteLine(st1.name);
    Console.WriteLine(st1.age);
    Console.WriteLine(st1.grade);
  }
}
