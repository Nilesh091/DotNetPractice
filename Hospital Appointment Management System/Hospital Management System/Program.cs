using Hospital_Management_System.Models;

namespace Hospital_Management_System
{
  class Program
  {
    public static void AddPatient(string name, string gender, DateOnly date, string phone, string email)
    {
      using var context = new HospitalDbContext();

      var patient = new Patient
      {
        PatientName = "Anita Verma",
        Gender = "Female",
        DateOfBirth = new DateOnly(2000, 3, 15),
        Phone = "9123456780",
        Email = "anita.verma@gmail.com"
      };

      context.Patients.Add(patient);
      context.SaveChanges();
      Console.WriteLine("Patient added successfully.");
    }
    public static void Main()
    {
    }
  }
}