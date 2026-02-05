using System;
using System.Data;
using Microsoft.Data.SqlClient;

class RetrieveData
{
  public void Retrieve(SqlConnection con)
  {
    con.Open();

    string retrievalQuery = @"select * from employee";
    SqlCommand cmd = new SqlCommand(retrievalQuery, con);
    SqlDataReader reader = cmd.ExecuteReader();
    Console.WriteLine("We are reading from the server.");
    while (reader.Read())
    {
      int id = Convert.ToInt32(reader["Id"]);
      string name = reader["Name"].ToString();
      int salary = Convert.ToInt32(reader["Salary"]);
      Console.WriteLine("Id :" + id + " Name :" + name + " Salary :" + salary);
    }


    con.Close();
  }

}