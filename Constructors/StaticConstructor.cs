class StaticConstructor
{
  static int n;
  static StaticConstructor()
  {
    n = 10;
    Console.WriteLine("n={0}", n);
  }
}