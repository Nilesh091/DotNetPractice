using System;
class Program
{
  public static void Main()
  {
    EmpIndexer emp = new EmpIndexer();
    emp[0] = "String 1";
    // emp[1] = "String 2";
    // emp[2] = "String 3";
    // emp[3] = "String 4";
    // emp[4] = "String 5";

    // for (int i = 0; i < 5; i++)
    // {
    //   Console.WriteLine(emp[i]);
    // }

    // Console.WriteLine("value string 4 is at index {0}", emp["String 4"]);

    // int a = 0, b = 0, res = 0;
    // try
    // {
    //   a = Convert.ToInt32(Console.ReadLine());
    //   b = Convert.ToInt32(Console.ReadLine());
    //   res = a / b;
    // }
    // catch (DivideByZeroException ex)
    // {
    //   Console.WriteLine("cannot divide by zero" + ex.Message);
    // }
    // catch (FormatException ex)
    // {
    //   Console.WriteLine("Enter number only" + ex.Message);
    // }
    // finally
    // {
    //   Console.WriteLine($"Division of {a} and {b} is {res}");
    // }



    // int num1, num2, result;
    // int[] arr = { 10, 20, 30, 40, 50, 60 };

    // try
    // {
    //   Console.WriteLine("Enter first number");
    //   num1 = Convert.ToInt32(Console.ReadLine());

    //   Console.WriteLine("Enter Second number");
    //   num2 = Convert.ToInt32(Console.ReadLine());

    //   result = num1 / num2;

    //   for (int i = 0; i < 9; i++)
    //   {
    //     Console.WriteLine(arr[i]);
    //   }
    // }
    // catch (IndexOutOfRangeException ex)
    // {
    //   Console.WriteLine($"index is out of range{ex.Message}");
    // }
    // catch (DivideByZeroException ex)
    // {
    //   Console.WriteLine("cannot divide by zero" + ex.Message);
    // }
    // catch (FormatException ex)
    // {
    //   Console.WriteLine("Enter number only" + ex.Message);
    // }

    try
    {
      throw new UDException();
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message.ToString());
    }
    finally
    {
      Console.WriteLine("Custom Exception created Successfully");
    }


  }
}