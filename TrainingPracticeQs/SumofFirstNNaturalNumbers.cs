using System;

class SumofFirstNNaturalNumbers
{
  public void calculateSum()
  {
    // Read input
    int N = int.Parse(Console.ReadLine());
    int sum = 0;
    // Calculate sum using for loop
    for (int i = 1; i <= N; i++)
    {
      sum += i;
    }
    // Print result
    Console.WriteLine(sum);
  }
}
