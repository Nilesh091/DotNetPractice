using System;
using System.Collections;


class MeditationCenter
{
  public int MemberId { get; set; }
  public int Age { get; set; }
  public double Weight { get; set; }
  public double Height { get; set; }
  public string Goal { get; set; }
  public double BMI { get; set; }

  public static ArrayList memberList = new ArrayList();
}

class Program
{
  static void Main(string[] args)
  {
    Program p = new Program();

    Console.WriteLine("Enter Member ID:");
    int memberId = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Age:");
    int age = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Weight (in kg):");
    double weight = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter Height (in meters):");
    double height = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter Goal (Weight Loss / Weight Gain):");
    string goal = Console.ReadLine();


    p.AddYogaMember(memberId, age, weight, height, goal);


    double bmi = p.CalculateBMI(memberId);

    if (bmi == 0)
    {
      Console.WriteLine($"MemberId \"{memberId}\" is not present");
    }
    else
    {
      Console.WriteLine($"Calculated BMI: {bmi}");


      int fee = p.CalculateYogaFee(memberId);

      if (fee == 0)
      {
        Console.WriteLine($"MemberId \"{memberId}\" is not present");
      }
      else
      {
        Console.WriteLine($"Yoga Membership Fee: {fee}");
      }
    }
  }


  public void AddYogaMember(int memberId, int age, double weight, double height, string goal)
  {
    MeditationCenter m = new MeditationCenter
    {
      MemberId = memberId,
      Age = age,
      Weight = weight,
      Height = height,
      Goal = goal
    };

    MeditationCenter.memberList.Add(m);
  }


  public double CalculateBMI(int memberId)
  {
    foreach (MeditationCenter m in MeditationCenter.memberList)
    {
      if (m.MemberId == memberId)
      {
        double bmi = m.Weight / (m.Height * m.Height);

        bmi = Math.Floor(bmi * 100) / 100;

        m.BMI = bmi;
        return bmi;
      }
    }

    return 0;
  }

  public int CalculateYogaFee(int memberId)
  {
    foreach (MeditationCenter m in MeditationCenter.memberList)
    {
      if (m.MemberId == memberId)
      {
        double bmi = m.BMI;

        if (m.Goal.Equals("Weight Loss", StringComparison.OrdinalIgnoreCase))
        {
          if (bmi >= 25 && bmi < 30)
            return 2000;
          else if (bmi >= 30 && bmi <= 35)
            return 2500;
          else if (bmi > 35)
            return 3000;
        }
        else if (m.Goal.Equals("Weight Gain", StringComparison.OrdinalIgnoreCase))
        {
          return 2500;
        }
      }
    }

    return 0;
  }
}

