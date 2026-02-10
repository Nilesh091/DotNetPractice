using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
class DisconnectedEnv
{
  public void GetAllStudents(SqlConnection con)
  {
    string sqlCommand = "select * from student";
    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand, con);
    DataSet data = new DataSet();
    adapter.Fill(data, "student");
    foreach (DataRow row in data.Tables["student"].Rows)
    {
      Console.WriteLine("Id: {0} Name: {1} Course: {2} Marks: {3}", row["student_id"], row["name"], row["course"], row["marks"]);
    }

  }
  public void GetStudentById(SqlConnection con, int id)
  {
    string sqlCom = "select * from student where student_id = '" + id + "'";
    SqlDataAdapter cmd = new SqlDataAdapter(sqlCom, con);
    DataSet data = new DataSet();
    cmd.Fill(data, "student");
    bool isStudentFound = false;
    foreach (DataRow reader in data.Tables["student"].Rows)
    {
      Console.WriteLine("Id: {0} Name: {1} Course: {2} Marks: {3}", reader["student_id"], reader["name"], reader["course"], reader["marks"]);
      isStudentFound = true;
    }
    if (!isStudentFound)
    {
      Console.WriteLine("Student not found.");
    }

    // string sqlCom = "SELECT * FROM student";
    // SqlDataAdapter adapter = new SqlDataAdapter(sqlCom, con);

    // DataSet data = new DataSet();
    // adapter.Fill(data, "student");

    // bool isStudentFound = false;

    // foreach (DataRow row in data.Tables["student"].Rows)
    // {
    //   // filter inside foreach
    //   if (row["student_id"].ToString() == id)
    //   {
    //     Console.WriteLine(
    //         "Id: {0} Name: {1} Course: {2} Marks: {3}",
    //         row["student_id"],
    //         row["name"],
    //         row["course"],
    //         row["marks"]
    //     );

    //     isStudentFound = true;
    //     break; // stop once found
    //   }
    // }

    // if (!isStudentFound)
    // {
    //   Console.WriteLine("Student not found.");
    // }

  }
  public void GetStudentByName(SqlConnection con, string name)
  {
    string sqlCom = "select * from student where name = '" + name + "'";
    SqlDataAdapter cmd = new SqlDataAdapter(sqlCom, con);
    DataSet data = new DataSet();
    cmd.Fill(data, "student");
    bool isStudentFound = false;
    foreach (DataRow reader in data.Tables["student"].Rows)
    {
      Console.WriteLine("Id: {0} Name: {1} Course: {2} Marks: {3}", reader["student_id"], reader["name"], reader["course"], reader["marks"]);
      isStudentFound = true;
    }
    if (!isStudentFound)
    {
      Console.WriteLine("Student not found.");
    }
  }

  public void GetStudentByCourse(SqlConnection con, string course)
  {
    string sqlCom = "select * from student where course = '" + course + "'";
    SqlCommand cmd = new SqlCommand(sqlCom, con);
    SqlDataReader reader = cmd.ExecuteReader();

    while (reader.Read())
    {
      Console.WriteLine("Id: {0} Name: {1} Course: {2} Marks: {3}", reader["student_id"], reader["name"], reader["course"], reader["marks"]);
    }
  }

  public void AddnewStudent(SqlConnection con, int id, string name, string course, int marks)
  {
    // string command = $"insert into student values({id},'{name}','{course}',{marks})";
    // SqlCommand cmd = new SqlCommand(command, con);
    // int count = cmd.ExecuteNonQuery();
    // Console.WriteLine(count + " rows are inserted");

    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from student", con);
    DataSet data = new DataSet();
    sqlDataAdapter.Fill(data, "student");
    DataRow row = data.Tables["student"].NewRow();
    row[0] = id;
    row[1] = name;
    row[2] = course;
    row[3] = marks;
    data.Tables["student"].Rows.Add(row);

    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(sqlDataAdapter);
    sqlDataAdapter.Update(data, "student");

  }

  public void UpdateStudent(SqlConnection con, int id, string name, string course, int marks)
  {
    SqlDataAdapter sqlDataAdapter =
        new SqlDataAdapter("SELECT * FROM student", con);

    DataSet data = new DataSet();
    sqlDataAdapter.Fill(data, "student");

    bool isUpdated = false;

    // foreach (DataRow row in data.Tables["student"].Rows)
    // {
    //   if (Convert.ToInt32(row["student_id"]) == id)
    //   {
    //     row["name"] = name;
    //     row["course"] = course;
    //     row["marks"] = marks;

    //     isUpdated = true;
    //     break;
    //   }
    // }

    for (int i = 0; i < data.Tables["student"].Rows.Count; i++)
    {
      if (Convert.ToInt32(data.Tables["student"].Rows[i][0]) == id)
      {
        data.Tables["student"].Rows[i][1] = name;
        data.Tables["student"].Rows[i][2] = course;
        data.Tables["student"].Rows[i][3] = marks;
        isUpdated = true;
      }
    }

    if (isUpdated)
    {
      SqlCommandBuilder sqlCommandBuilder =
          new SqlCommandBuilder(sqlDataAdapter);

      sqlDataAdapter.Update(data, "student");
      Console.WriteLine("Student record updated successfully.");
    }
    else
    {
      Console.WriteLine("Student not found.");
    }
  }
  public void DeleteStudent(SqlConnection con, int id)
  {
    SqlDataAdapter sqlDataAdapter =
        new SqlDataAdapter("SELECT * FROM student", con);

    DataSet data = new DataSet();
    sqlDataAdapter.Fill(data, "student");

    bool isDeleted = false;

    for (int i = 0; i < data.Tables["student"].Rows.Count; i++)
    {
      if (Convert.ToInt32(data.Tables["student"].Rows[i][0]) == id)
      {
        data.Tables["student"].Rows[i].Delete();
        Console.WriteLine("Student record deleted successfully.");
        isDeleted = true;
        break;
      }
    }

    if (isDeleted)
    {
      SqlCommandBuilder sqlCommandBuilder =
          new SqlCommandBuilder(sqlDataAdapter);

      sqlDataAdapter.Update(data, "student");
      Console.WriteLine("Student record updated successfully.");
    }
    else
    {
      Console.WriteLine("Student not found.");
    }
  }


}