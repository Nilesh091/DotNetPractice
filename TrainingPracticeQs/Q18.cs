class Q18
{
  public void printQ18()
  {
    Console.WriteLine("Enter a number such that I can print even numbers from 1 to that number");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= num; i++)
    {
      if (i % 2 == 0)
      {
        Console.WriteLine(i);
      }
    }
  }
}