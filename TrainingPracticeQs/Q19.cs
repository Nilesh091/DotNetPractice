class Q19
{
  public void printQ19()
  {
    Console.WriteLine("Enter a number such that i can calculate the sum of numbers from 1 to that number");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
      sum += i;
    }
    Console.WriteLine("The sum is: " + sum);
  }
}