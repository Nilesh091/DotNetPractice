// See https://aka.ms/new-console-template for more information
class Program
{
  static void Main(string[] args)
  {
    StaticVariables n1 = new StaticVariables();
    Console.WriteLine(StaticVariables.n);
    n1.increamnet();
    Console.WriteLine(StaticVariables.n);
    StaticVariables n2 = new StaticVariables();
    Console.WriteLine(StaticVariables.n);
    n2.increamnet();
    Console.WriteLine(StaticVariables.n);
  }
}
