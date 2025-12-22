using System;

class Calculator
{
  //propertise implementation
  public int Number1 { get; set; }

  public int Number2 { get; set; }

  public int Result { get; set; }

  public Calculator() //default constructor
  {
    Number1 = 0;
    Number2 = 0;
    Result = 0;
  }

  public Calculator(int Number1, int Number2) //parameterised constructor
  {
    this.Number1 = Number1;
    this.Number2 = Number2;
  }

  //Method with return type and with parameters
  public int sum(int Number1, int Number2)
  {
    return Number1 + Number2;
  }

  //Method with return type but without parameter
  public int subtract()
  {
    Number1 = 10;
    Number2 = 20;

    Result = Number2 - Number1;

    return Result;
  }

  //Method without return type and with parameter
  public void Multiplication(int Number1, int Number2)
  {
    Console.WriteLine($"The Multiplication of {Number1} and {Number2} is {Number1 * Number2}");
  }

  // Method without return and Parameter
  public void Divide()
  {
    int Number1 = 100;
    int Number2 = 50;

    int Division = Number1 / Number2;

    Console.WriteLine($"The division of {Number1} and {Number2} is {Division}");
  }

  //inparameter or PassByValue

  //Pass by Value (current implementation - doesn't affect original variables)
  public void Swap(int Number1, int Number2)
  {
    int temp = Number1;
    Number1 = Number2;
    Number2 = temp;

    Console.WriteLine($"Inside Swap (Pass by Value):After Swapping Number1 is {Number1} and Number2 is {Number2}");

  }

  //Pass by Reference using 'ref' keyword (affects original variables)
  public void SwapByRef(ref int Number1, ref int Number2)
  {
    int temp = Number1;
    Number1 = Number2;
    Number2 = temp;

    Console.WriteLine($"Inside Swap (Pass By Reference): Number1 is {Number1} and Number2 is {Number2}");
  }

  //Pass by Reference using 'out' keyword (must assign values inside method)
  public void SwapByOut(int num1, int num2, out int result1, out int result2)
  {
    result1 = num2;
    result2 = num1;

    Console.WriteLine($"Inside Swap (Pass By Out): result1 is {result1} and result2 is {result2}");
  }

  // internal void SwapByOut(int number1, int number2, out int res2)
  // {
  //   throw new NotImplementedException();
  // }
}