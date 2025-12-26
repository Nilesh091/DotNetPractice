using System.Runtime.CompilerServices;

class AnonymousDelegate
{
  public delegate int Cal(int x, int y);
  public void Run()
  {
    Cal c = delegate (int x, int y) { return (x + y); };
    Console.WriteLine(c(10, 20));
  }
}