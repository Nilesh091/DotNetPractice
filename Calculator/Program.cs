using System;

class Program
{
  public static void Main(string[] args)
  {
    Calculator calculator1 = new Calculator(); //Default Constructor calling

    int Number1 = 20;
    int Number2 = 30;
    int sum = calculator1.sum(Number1, Number2);
    Console.WriteLine($"The sum of numbers {Number1} and {Number2} is {sum}");


    Calculator calculator2 = new Calculator(Number1, Number2);   //Calling new Parameterised Constructor

    int substraction = calculator2.subtract();
    Console.WriteLine($"The substraction of {calculator2.Number2} and {calculator2.Number1} is {substraction}");

    calculator2.Multiplication(Number1, Number2);

    calculator1.Divide();

    //Pass by value - original variables remain unchanged
    calculator1.Swap(Number1, Number2);
    Console.WriteLine($"After Swap (Pass By Value): Number1 is {Number1} and Number2 is {Number2} \n");

    //Pass by Reference - original variables are swapped
    calculator1.SwapByRef(ref Number1, ref Number2);
    Console.WriteLine($"After Swap(Pass By Reference): Number1 is {Number1} and Number2 is {Number2}\n");

    // //Pass By Out
    // calculator1.SwapByOut(Number1, Number2, out int res2);
    // Console.WriteLine($"After Swap (Pass By Out): res1 is {res1} and res2 is {res2}");


  }
}