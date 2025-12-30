class JaggedArray
{
  public static void jaggedArray()
  {
    int[][] jagged = new int[3][];
    jagged[0] = new int[] { 1, 2 };
    jagged[1] = new int[] { 4, 5, 6 };
    jagged[2] = new int[] { 7 };
    printJaggedArray(jagged);
    // in java by default Jagged array is initialized with null values.
  }

  public static void printJaggedArray(int[][] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
      for (int j = 0; j < arr[i].Length; j++)
        System.Console.WriteLine(arr[i][j]);
    }
  }
  public static void Method2ForPrintingJaggedArray(int[][] arr)
  {
    foreach (var item in arr)
    {
      foreach (var element in item)
        System.Console.WriteLine(element);
    }
  }
}