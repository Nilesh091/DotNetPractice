using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

class Program
{
  public static void Main()
  {
    ArrayList al = new ArrayList();
    while (true)
    {
      string input = Console.ReadLine();
      if (input == "stop")
      {
        break;
      }
      if (isDuplicate(al, input))
      {
        Console.WriteLine("The Name :" + input + " Provided Previously");
      }
      else
      {
        al.Add(input);
        Console.WriteLine("Name added successfully");
      }

    }
    DisplayNames(al);
  }

  private static bool isDuplicate(ArrayList v, string inp)
  {
    foreach (var n in v)
    {
      if (n.Equals(inp)) return true;
    }
    return false;
  }

  private static void DisplayNames(ArrayList v)
  {
    foreach (string li in v)
    {
      Console.WriteLine(li);
    }
  }
}