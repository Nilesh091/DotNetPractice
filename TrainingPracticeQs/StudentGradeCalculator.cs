using System;

class StudentGradeCalculator
{
  public void calculateGrade()
  {
    // Read input score
    int score = int.Parse(Console.ReadLine());

    // Determine grade using nested if statements
    if (score >= 90)
    {
      Console.WriteLine("Grade: A");
    }
    else
    {
      if (score >= 80)
      {
        Console.WriteLine("Grade: B");
      }
      else
      {
        if (score >= 70)
        {
          Console.WriteLine("Grade: C");
        }
        else
        {
          if (score >= 60)
          {
            Console.WriteLine("Grade: D");
          }
          else
          {
            Console.WriteLine("Grade: P");
          }
        }
      }
    }
  }
}
