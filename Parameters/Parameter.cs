class Parameter
{
  //implementing value parameter
  public void ValueParameter(int x, int y)
  {
    Console.WriteLine(x + y);
    Console.WriteLine("Inside ValueParameter method");
  }

  //implementing reference parameter
  public void ReferenceParameter(ref int x, ref int y)
  {
    x = x + 10;
    y = y + 20;

  }
  //implementing output parameter
  public void OutputParameter(out int x, out int y)
  {
    x = 5;
    y = 6;
  }
  //implementing params parameter
  public void ParamsParameter(params int[] numbers)
  {
    foreach (int n in numbers)
    {
      Console.WriteLine(n);
    }
  }
  //implementing optional parameter
  public void OptionalParameter(string name, string email = "nilu@gmail.com")
  {
    Console.WriteLine($"name:{name}::: email:{email}");
  }
  //implementing named parameter
  public void NamedParameter(string name, int age)
  {
    Console.WriteLine($"{name}.  {age}");
  }

}