using System;
using System.Collections;
class MyCollection : IEnumerable
{
  int[] data = { 1, 2, 3 };
  public IEnumerator GetEnumerator()
  {
    return data.GetEnumerator();
  }
}


class Program
{
  public static void Main(string[] args)
  {

    MyCollection obj = new MyCollection();
    foreach (int i in obj)
    {
      Console.WriteLine(i);
    }
  }
}