using System.ComponentModel.DataAnnotations;
using EFCoreValidationStudentManagementSystem.Data;
using EFCoreValidationStudentManagementSystem.Model;

namespace EFCoreValidationStudentManagementSystem
{
  class Program
  {
    public static void Main()
    {
      var context = new Context();
      var course = new Course
      {
        Name = "Asp .Net c#"
      };
      context.Courses.Add(course);
      context.SaveChanges();
      var student = new Student
      {
        Name = "Nilu",
        Email = "Nilu.gmail.com",
        Age = 66,
        EnrollmentDate = DateTime.Now.AddDays(5),
        CourseId = course.CourseId
      };
      // context.Students.Add(student);
      // context.SaveChanges();
      ValidateAndSave(context, student);
    }
    static void ValidateAndSave(Context context, Student student)
    {
      var validationResults = new List<ValidationResult>();
      var validationContext = new ValidationContext(student);

      bool IsValid = Validator.TryValidateObject(
        student,
        validationContext,
        validationResults,
        true
      );

      if (!IsValid)
      {
        Console.WriteLine("ValidationError: ");
        foreach (var error in validationResults)
        {
          Console.WriteLine(error.ErrorMessage);
        }
        return;
      }

      try
      {
        context.Students.Add(student);
        context.SaveChanges();
        Console.WriteLine("Student saved Successfully.");

      }
      catch (Exception e)
      {
        Console.WriteLine(e.InnerException?.Message ?? e.Message);
      }
    }
  }
}