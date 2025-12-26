class DelegareWithParameter
{
  public delegate void myDeligate(int a, int b);

  public void Example(int a, int b)
  {
    Console.WriteLine(a + b);
  }
  public void Run()
  {
    myDeligate del = Example;
    del(20, 30);
  }
  
}