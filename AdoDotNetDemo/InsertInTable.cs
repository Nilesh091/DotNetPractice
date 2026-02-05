using Microsoft.Data.SqlClient;

class InsertInTable
{
  public void Insert(SqlConnection con)
  {
    string insertQuery = @"
        INSERT INTO Employee (Id, Name, Salary)
        VALUES (1, 'Nilesh', 50000),
               (2, 'Amit', 60000)";
    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
    {
      cmd.ExecuteNonQuery();
      Console.WriteLine("Data inserted in the Employee table");
    }

  }
}