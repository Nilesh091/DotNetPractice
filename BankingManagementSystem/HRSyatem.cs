class HRSyatem
{
  public void swap(ref int a, ref int b)
  {
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine("After swapping a: " + a + " b: " + b);
  }
}