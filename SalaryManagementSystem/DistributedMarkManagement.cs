using System;

class DistributedMarkManagement
{

  private int studentId;
  private string name;
  private int[] marks = new int[6];


  public int StudentId
  {
    get { return studentId; }
    set { studentId = value; }
  }

  public string Name
  {
    get { return name; }
    set { name = value; }
  }

  public int[] Marks
  {
    get { return marks; }
    set { marks = value; }
  }


  public void ReadStudentDetails()
  {
    Console.WriteLine("Enter Student ID:");
    StudentId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Student Name:");
    Name = Console.ReadLine();

    Console.WriteLine("Enter marks of 6 subjects:");
    for (int i = 0; i < 6; i++)
    {
      marks[i] = Convert.ToInt32(Console.ReadLine());
    }
  }

  // Method to calculate and display result
  public void CalculateResult()
  {
    int total = 0;
    for (int i = 0; i < 6; i++)
    {
      total += marks[i];
    }

    double average = total / 6.0;
    char grade;
    string division;

    if (average >= 90)
      grade = 'A';
    else if (average >= 80)
      grade = 'B';
    else if (average >= 70)
      grade = 'C';
    else if (average >= 60)
      grade = 'D';
    else
      grade = 'F';

    if (average >= 60)
      division = "Pass";
    else
      division = "Fail";

    Console.WriteLine("\nStudent Result:");
    Console.WriteLine("Student ID: " + StudentId);
    Console.WriteLine("Student Name: " + Name);
    Console.WriteLine("Total Marks: " + total);
    Console.WriteLine("Average: " + average);
    Console.WriteLine("Grade: " + grade);
    Console.WriteLine("Division: " + division);
  }
}