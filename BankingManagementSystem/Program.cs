// See https://aka.ms/new-console-template for more information
using System;
class Program
{
  static void Main(string[] args)
  {
    //Inplemented Calculator Operations
    Bms b = new Bms(50, 30);
    b.result = b.Addition(b.Number1, b.Number2);
    Console.WriteLine($"Addition of {b.Number1} and {b.Number2} is : {b.result}");
    b.result = b.Substraction();
    Console.WriteLine($"Substraction of {b.Number1} and {b.Number2} is : {b.result}");
    b.result = b.Multiplication(b.Number1, b.Number2);
    Console.WriteLine($"Multiplication of {b.Number1} and {b.Number2} is : {b.result}");
    b.Division();
    Console.WriteLine($"Division of {b.Number1} and {b.Number2} is : {b.result}");
    Console.ReadKey();

    //Call by Value
    int a1 = 10, a2 = 20;
    EmployeePayroll emp = new EmployeePayroll();
    Console.WriteLine("Before swapping a: " + a1 + " b: " + a2);
    emp.swap(a1, a2);
    Console.WriteLine("Outside method a: " + a1 + " b: " + a2);

    //Call by Reference
    int b1 = 30, b2 = 40;
    HRSyatem hr = new HRSyatem();
    Console.WriteLine("Before swapping a: " + b1 + " b: " + b2);
    hr.swap(ref b1, ref b2);
    Console.WriteLine("Outside method a: " + b1 + " b: " + b2);
    //Out Parameter
    int n1 = 15, n2 = 25;
    ExaminationSyatem exam = new ExaminationSyatem();
    exam.Exam(n1, n2, out int sum, out int n3, out int n4);
    Console.WriteLine($"Sum of {n1} and {n2} is: {sum}");
    Console.WriteLine("Subject Marks: " + n3 + ", " + n4);
    Console.ReadKey();
  }
}
