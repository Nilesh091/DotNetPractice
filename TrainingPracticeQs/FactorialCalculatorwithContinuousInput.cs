using System;

class FactorialCalculatorwithContinuousInput
{
  public void calculateFactorials()
  {
    while (true)
    {
      // Prompt user
      string input = Console.ReadLine();
      // Quit condition
      if (input == "q")
      {
        break;
      }
      // Try parsing input
      bool isNumber = int.TryParse(input, out int number);
      if (!isNumber)
      {
        Console.WriteLine("Invalid input! Please enter a non-negative integer.");
        continue;
      }
      if (number < 0)
      {
        Console.WriteLine("Invalid input! Please enter a non-negative integer.");
        continue;
      }
      // Calculate factorial
      long factorial = 1;
      for (int i = 1; i <= number; i++)
      {
        factorial *= i;
      }
      // Print result
      Console.WriteLine($"The factorial of {number} is {factorial}.");
    }
  }
}
