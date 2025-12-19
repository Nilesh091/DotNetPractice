using System;
using System.Data;
class Calcualator
{
  public int calculate(int a, int b, char op)
  {
    switch (op)
    {
      case '+':
        return a + b;
      case '-':
        return a - b;
      case '*':
        return a * b;
      case '/':
        return a / b;

      default:
        return 0;
    }
  }
}