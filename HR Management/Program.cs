using System.Data;
using Microsoft.Data.SqlClient;
class Program
{
  public static void Main()
  {
    string connString = "Server=localhost,1433;Database=HRDB;User Id=sa;Password=2004@Nilu;TrustServerCertificate=True;";
    SqlConnection connection = new SqlConnection(connString);
    connection.Open();
    SqlDataAdapter department = new SqlDataAdapter("select * from Departments", connection);
    SqlDataAdapter employees = new SqlDataAdapter("select * from Employees", connection);
    SqlDataAdapter salaries = new SqlDataAdapter("select * from Departments", connection);

    DataSet dataSet = new DataSet();
    department.Fill(dataSet, "Department");
    employees.Fill(dataSet, "Employees");
    salaries.Fill(dataSet, "Salarues");

    dataSet.Relations.Add(
      "dept_emp",
        dataSet.Tables["Departments"].Columns["DepartmentId"],
        dataSet.Tables["Employees"].Columns["DepartmentId"]
    );

    dataSet.Relations.Add(
        "Emp_Salary",
        dataSet.Tables["Employees"].Columns["EmployeeId"],
        dataSet.Tables["Salaries"].Columns["EmployeeId"]
      );
    Console.WriteLine("Relations Created:");
    foreach (DataRelation rel in dataSet.Relations)
    {
      Console.WriteLine(rel.RelationName);
    }
    connection.Close();

  }
}