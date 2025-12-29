class PrintAllTheUniqueElementsOfAnArray
{
  public static void printUniqueElements(int[] arr)
  {
    for (int i = 0; i < arr.Length; i++)
    {
      //Assume the current element is unique.
      bool isUnique = true;
      for (int j = i + 1; j < arr.Length; j++)
      {
        if (arr[i] == arr[j])
          isUnique = false;
      }
      for (int k = 0; k < i; k++)
      {
        if (arr[k] == arr[i])
          isUnique = false;
      }
      if (isUnique)
        Console.WriteLine("Element at index " + i + " :" + arr[i]);

    }
  }
}