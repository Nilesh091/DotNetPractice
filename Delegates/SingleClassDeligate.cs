using System;
class SingleClassDelegate
{
  public delegate void myDeligate();
  public void example()
  {
    Console.WriteLine("This is an example of Single Class Delegate");
  }
  public void Run()
  {
    myDeligate del = example;
    del();
  }

}