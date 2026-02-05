// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using Microsoft.Data.SqlClient;


class Program
{
  public static void Main()
  {
    string connString = "Server=localhost,1433;Database=student_db;User Id=sa;Password=2004@Nilu;TrustServerCertificate=True;";
    // integrated security = true insted of User Id=sa;Password=2004@Nilu;
    SqlConnection con = new SqlConnection(connString);
    con.Open();
    CRUD crud = new CRUD();
    crud.GetAllStudents(con);
    //crud.GetStudentByName(con, "Priya Singh");
    //crud.AddnewStudent(con, 6, "nilesh ranjan", "cse", 90);

    con.Close();

    Console.ReadLine();
    //Console.WriteLine("Connected to SQL Server successfully!");
  }
}
