class Program
{
  static void Main(string[] args)
  {
    Program p = new Program();
    // int[] arr = p.returnArray();
    // foreach (int i in arr)
    //   Console.WriteLine(i);


    // int[,] newArr = p.returnTwoDArray();
    // for (int i = 0; i < newArr.GetLength(0); i++)
    // {
    //   for (int j = 0; j < newArr.GetLength(1); j++)
    //   {
    //     Console.Write(newArr[i, j] + " ");
    //   }
    //   Console.WriteLine();
    // }
    // int[] arr = { 1, 23, 45, 1, 2, 1, 3, 23 };
    // int countNumberOfDuplicateElements = NumberOfDuplicateElementsinAnArray.returnCountduplicateElements(arr);
    // Console.WriteLine("The number of duplicate elements in the array are: " + countNumberOfDuplicateElements);
    // Console.WriteLine("The unique elements in the array are: ");
    // PrintAllTheUniqueElementsOfAnArray.printUniqueElements(arr);
    // FrequencyOfAElement.printFrequencyofEachElement(arr);

    // ComparablesInCsharp.AccessObject();
    int[] arr1 = { 12, 43, 10, 8 };
    int[] arr2 = { 13, 15, 17, 9 };
    MergeSort.ImplementMergeSort(arr1);
    MergeSort.ImplementMergeSort(arr2);
    int[] aftersortingAndMergingTwoUnsortedArray = MergeTwoSortedArray.mergeTwoSortedArray(arr1, arr2);
    foreach (int n in aftersortingAndMergingTwoUnsortedArray)
    {
      Console.WriteLine(n);
    }
  }
  public int[] returnArray()
  {
    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
    return arr;
  }

  //a function to return a 2d array
  public int[,] returnTwoDArray()
  {
    //create a 3x3 matrix and take input from user
    int[,] arr = new int[3, 3];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
        arr[i, j] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
  }
}
