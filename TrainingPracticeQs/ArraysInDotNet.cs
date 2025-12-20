using System.Data;

class Arrays
{
  public void createArray()
  {
    int[] arr = new int[5];
    arr[0] = 10;
    arr[1] = 20;
    arr[2] = 30;
    arr[3] = 40;
    arr[4] = 50;
    Console.WriteLine("Array created");
    Console.WriteLine("Printling array elements: using foreach");
    printArrayUsingForEach(arr);
    Console.WriteLine("Printling array elements: using for and index");
    printArrayUsingIndex(arr);

  }
  public void printArrayUsingIndex(int[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
      Console.WriteLine(i + " : " + arr[i]);
    }
  }
  public void printArrayUsingForEach(int[] arr)
  {
    foreach (int i in arr)
    {
      Console.WriteLine(i);
    }

  }
}