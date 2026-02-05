using Microsoft.Data.SqlClient;

class CreateTable
{
  public void CreateTableFun(SqlConnection con)
  {
    string createTableQuery = @"
        IF OBJECT_ID('Employee', 'U') IS NULL
        CREATE TABLE Employee (
            Id INT PRIMARY KEY,
            Name VARCHAR(50),
            Salary INT
        )";
    using (SqlCommand cmd = new SqlCommand(createTableQuery, con))
    {
      cmd.ExecuteNonQuery();
      Console.WriteLine("Table created successfully.");
    }

  }
}