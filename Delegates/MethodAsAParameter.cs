class MethodAsAParameter
{
  public delegate int Calculation(int a, int b);
  public int Addition(int a, int b)
  {
    return a + b;
  }

  public void process(int a, int b, Calculation operation)
  {
    Console.WriteLine("Result is " + operation(a, b));
  }

  public void Run()
  {
    Calculation cal = Addition;
    process(10, 20, cal);
  }
}