// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
class Program
{
  public static void Main(string[] args)
  {
    Parameter p = new Parameter(); // object is created
    //implementing value paramenter
    //A copy of the value is passed
    // Changes inside the method do not affect the original variable
    int n = 20;
    p.ValueParameter(n, 30); // passing value parameter
    Console.WriteLine("value of n after method call:" + n); // original value remains unchanged
    Console.WriteLine("--------------------------------------------------");
    //implementing reference parameter
    //The reference (address) of the variable is passed
    //Changes inside the method affect the original variable
    int a = 10;
    int b = 20;
    p.ReferenceParameter(ref a, ref b); // passing reference parameter
    Console.WriteLine("value of a after method call:" + a); // original value is changed
    Console.WriteLine("value of b after method call:" + b); // original value is changed
    Console.WriteLine("--------------------------------------------------");
    //implementing output parameter
    //Used to return multiple values from a method
    int c, d;
    p.OutputParameter(out c, out d); // passing output parameter
    Console.WriteLine("value of c after method call:" + c); // original value is changed
    Console.WriteLine("value of d after method call:" + d); // original value is changed
    Console.WriteLine("--------------------------------------------------");
    //implementing params parameter
    //Allows passing a variable number of arguments to a method
    p.ParamsParameter(1, 2, 3, 4, 5); // passing params parameter
    Console.WriteLine("--------------------------------------------------");
    //implementing optional parameter
    //Parameters that have a default value
    p.OptionalParameter("Nilu"); // passing optional parameter
    p.OptionalParameter("Nilu", "nilu@ gmail.com"); // passing optional parameter with custom email
    Console.WriteLine("--------------------------------------------------");
    //implementing named parameter
    //Allows passing arguments by specifying parameter names
    p.NamedParameter(age: 25, name: "Nilu"); // passing named parameter
    Console.WriteLine("--------------------------------------------------");
  }
}
