class LambdaDeligate
{
  public void Run()
  {
    var del = (int x) => x * x;
    Console.WriteLine(del(5));
  }
}