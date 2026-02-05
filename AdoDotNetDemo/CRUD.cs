using Microsoft.Data.SqlClient;

class CRUD
{
  public void GetAllStudents(SqlConnection con)
  {
    string sqlCommand = "select * from student";
    SqlCommand com = new SqlCommand(sqlCommand, con);
    SqlDataReader reader = com.ExecuteReader();
    while (reader.Read())
    {
      Console.WriteLine("Id: {0} Name: {1} Course: {2} Marks: {3}", reader["student_id"], reader["name"], reader["course"], reader["marks"]);
    }

  }
  public void GetStudentById(SqlConnection con, int id)
  {
    string sqlCom = "select * from student where student_id = '" + id + "'";
    SqlCommand cmd = new SqlCommand(sqlCom, con);
    SqlDataReader reader = cmd.ExecuteReader();

    while (reader.Read())
    {
      Console.WriteLine("Id: {0} Name: {1} Course: {2} Marks: {3}", reader["student_id"], reader["name"], reader["course"], reader["marks"]);
    }
  }
  public void GetStudentByName(SqlConnection con, string name)
  {
    string sqlCom = "select * from student where name = '" + name + "'";
    SqlCommand cmd = new SqlCommand(sqlCom, con);
    SqlDataReader reader = cmd.ExecuteReader();

    while (reader.Read())
    {
      Console.WriteLine("Id: {0} Name: {1} Course: {2} Marks: {3}", reader["student_id"], reader["name"], reader["course"], reader["marks"]);
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
    string command = $"insert into student values({id},'{name}','{course}',{marks})";
    SqlCommand cmd = new SqlCommand(command, con);
    cmd.ExecuteNonQuery();
  }
}