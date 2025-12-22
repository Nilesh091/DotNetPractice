class Bms
{
  public int Number1 { get; set; }
  public int Number2 { get; set; }
  public double result { get; set; }

  public Bms()
  {
    Number1 = 10;
    Number2 = 5;
  }
  public Bms(int n1, int n2)
  {
    this.Number1 = n1;
    this.Number2 = n2;
  }

  public int Addition(int n1, int n2)
  {
    return n1 + n2;
  }
  public int Substraction()
  {
    return Number1 - Number2;
  }
  public int Multiplication(int n1, int n2)
  {
    return n1 * n2;
  }
  public void Division()
  {
    if (Number2 != 0)
    {
      result = Number1 / Number2;
      Console.WriteLine("Division is: " + result);
    }
    else
    {
      Console.WriteLine("Division by zero is not allowed.");
    }
  }
}