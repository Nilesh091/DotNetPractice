using System.Data;

class Employee : DataTable
{
  public Employee()
  {
    this.Columns.Add("Id", typeof(int));
    this.Columns.Add("Name", typeof(string));
    this.Columns.Add("Age", typeof(int));
    this.Columns.Add("Department", typeof(string));
    this.Columns.Add("Salary", typeof(int));
  }
}