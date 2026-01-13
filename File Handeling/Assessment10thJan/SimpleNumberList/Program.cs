using System;
using System.Collections;
using System.Transactions;

class Program
{
  public static void Main()
  {
    ArrayList al = new ArrayList();
    while (true)
    {
      Console.WriteLine("Enter Number");
      Console.WriteLine("1 : add");
      Console.WriteLine("2 : remove");
      Console.WriteLine("3 : display");
      Console.WriteLine("4 : exit");

      int n = Convert.ToInt32(Console.ReadLine());

      switch (n)
      {
        case 1:
          try
          {
            Console.WriteLine("Enter the number to add");
            al.Add(Convert.ToInt32(Console.ReadLine()));
          }
          catch (Exception e)
          {
            Console.WriteLine("Enter Valid Input");
          }
          break;

        case 2:
          Console.WriteLine("Enter the number to remove");
          al.Remove(Convert.ToInt32(Console.ReadLine()));
          break;
        case 3:
          DisplayTheNumbers(al);
          break;
        case 4:
          return;
      }

    }
  }
  private static void DisplayTheNumbers(ArrayList al)
  {
    foreach (int n in al) Console.WriteLine(n);
  }
}