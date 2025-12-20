class Q20
{
  public void printQ20()
  {
    Console.WriteLine("Enter a number such that i can print multiplication table of that number");
    int num = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine(i + " * " + num + " = " + (i * num));
    }
  }
}