using System;

class PrintFirstNEvenNumbers
{
  public void printFirstEvenNumbers()
  {
    // Read input
    int N = int.Parse(Console.ReadLine());
    // Print heading
    Console.WriteLine("First " + N + " even numbers:");
    // Generate and print first N even numbers
    for (int i = 1; i <= N; i++)
    {
      Console.WriteLine(2 * i);
    }
  }
}
