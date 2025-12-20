using System.Security.Cryptography;

class CalculateSalary
{
  public void SetEmployeeDetails(Employee emp, int eno, string ename, int basicSalary)
  {
    emp.Eno = eno;
    emp.Ename = ename;
    emp.BasicSalary = basicSalary;
  }
  public int CalculateNetSalary(Employee emp)
  {
    int pf = emp.BasicSalary * 12 / 100;
    int hra = emp.BasicSalary * 20 / 100;
    int da = emp.BasicSalary * 15 / 100;
    int grossSalary = emp.BasicSalary + pf + hra + da;
    int netSalary = grossSalary - pf;
    return netSalary;

  }
}