class Q22
{
  public void printQ22()
  {
    Console.WriteLine("Enter a number to print fibonacci series up to that number");
    int num = Convert.ToInt32(Console.ReadLine());
    // int a = 0, b = 1, c;
    // while (a + b <= num)
    // {
    //   c = a + b;
    //   Console.WriteLine(c);
    //   a = b;
    //   b = c;
    // }
    int i = 0;
    while (fibonacci(i) <= num)
    {
      Console.WriteLine(fibonacci(i));
      i++;
    }

  }
  // Printing Fibonacci using Reciursion
  public int fibonacci(int n)
  {
    if (n <= 1)
    {
      return n;
    }
    int fib = fibonacci(n - 1) + fibonacci(n - 2);

    return fib;
  }
}