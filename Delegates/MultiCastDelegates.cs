using System.ComponentModel;
using System.Data;

class MultiCastDelegates
{
  public delegate void Operation(int a, int b);
  public void addition(int a, int b)
  {
    Console.WriteLine("Addition of two numbers is " + (a + b));
  }
  public void subtraction(int a, int b)
  {
    Console.WriteLine("Subtraction of two numbers is " + (a - b));
  }
  public void multiplication(int a, int b)
  {
    Console.WriteLine("Multiplication of two numbers is " + (a * b));
  }
  public void division(int a, int b)
  {
    Console.WriteLine("Division of two numbers is " + (a / b));
  }
  public void Run()
  {
    Operation op = addition;
    op += subtraction;
    op += multiplication;
    op += division;
    op(10, 5);
  }


}