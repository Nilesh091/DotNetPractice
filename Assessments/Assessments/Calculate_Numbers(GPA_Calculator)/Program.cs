using System;
using System.Collections.Generic;

namespace CalculateNumbers
{
  class Program
  {
    public static List<int> NumberList = new List<int>();

    static void Main(string[] args)
    {
      Program p = new Program();
      Console.WriteLine("Enter the number of subjects:");
      int n = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter the numbers scored:");

      for (int i = 0; i < n; i++)
      {
        int num = Convert.ToInt32(Console.ReadLine());
        p.AddNumbers(num);
      }

      double gpa = p.GetGPAScored();

      if (gpa == -1)
      {
        Console.WriteLine("No Numbers Available");
      }
      else
      {
        Console.WriteLine($"GPA Scored: {gpa:F2}");

        char grade = p.GetGradeScored(gpa);

        if (grade == '\0')
        {
          Console.WriteLine("Invalid GPA");
        }
        else
        {
          Console.WriteLine("Grade Scored: " + grade);
        }
      }
    }

    public void AddNumbers(int Numbers)
    {
      NumberList.Add(Numbers);
    }

    public double GetGPAScored()
    {
      if (NumberList.Count == 0)
      {
        return -1;
      }

      double sum = 0;
      foreach (int num in NumberList)
      {
        sum += num * 3;
      }
      double gpa = sum / (NumberList.Count * 3);
      return gpa;
    }

    public char GetGradeScored(double gpa)
    {
      if (gpa < 5 || gpa > 10)
      {
        return '\0';
      }

      if (gpa == 10)
        return 'A';
      else if (gpa > 9 && gpa < 10)
        return 'B';
      else if (gpa >= 8 && gpa < 9)
        return 'C';
      else if (gpa >= 7 && gpa < 8)
        return 'D';
      else if (gpa >= 6 && gpa < 7)
        return 'E';
      else
        return 'F';
    }
  }
}
