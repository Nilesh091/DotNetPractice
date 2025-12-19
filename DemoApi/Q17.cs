class Q17
{
  public void q17()
  {
    Console.WriteLine("Enter  a number so that i can print numbers from 1 to that number");
    int num = Int32.Parse(Console.ReadLine());
    for (int i = 1; i <= num; i++)
    {
      Console.WriteLine(i);
    }
  }
}