using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
namespace EventHandeling
{
  class Program
  {
    public delegate void MyDelegate();

    public event MyDelegate myevent;
    static void Main(string[] args)
    {
      Program p = new Program();
      int result;
      result = 5 + 4;
      Console.WriteLine(result);

      if (result % 2 != 0 && p.myevent != null)
      {
        p.myevent();//Raised Event
      }
    }
  }
}