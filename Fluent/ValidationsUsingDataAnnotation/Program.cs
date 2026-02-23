using System;
using ValidationsUsingDataAnnotation.Models;
using ValidationsUsingDataAnnotation.Models.Context;
namespace ValidationsUsingDataAnnotation
{
  class Program
  {
    public static void Main()
    {
      ApplicationContext app = new ApplicationContext();

      app.Database.EnsureCreated();//??

      Student student = new Student
      {
        //Name = "Nilesh",
        Email = "Nilesh@gmail.com"
      };
      app.Students.Add(student);
      app.SaveChanges();
      Console.WriteLine("Student added successfully. ");
    }
  }
}