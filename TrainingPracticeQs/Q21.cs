class Q21
{
  public void printQ21()
  {
    Console.WriteLine("Enter the base");
    int baseNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the exponent");
    int exponent = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 1; i <= exponent; i++)
    {
      result = result * baseNum;
    }
    Console.WriteLine(baseNum + "^" + exponent + "=" + result);
  }
}