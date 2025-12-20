class Q24
{
  public void printQ24()
  {
    //Program to print armstrong numbers from n1 to n2
    Console.WriteLine("Enter entry number : ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter exit number : ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Q23 armstrong = new Q23();
    for (int i = num1; i <= num2; i++)
    {
      if (armstrong.isArmstrong(i, i.ToString().Length))
      {
        Console.WriteLine(i);
      }
    }
  }
}