class FrequencyOfAElement
{
  public static void printFrequencyofEachElement(int[] arr)
  {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      bool flag = true;
      for (int j = 0; j < i; j++)
      {
        if (arr[j] == arr[i])
        {
          flag = false;
        }
      }
      for (int k = i; k < arr.Length; k++)
      {
        if (arr[k] == arr[i]) count++;
      }
      if (flag)
      {
        Console.WriteLine($"The frequency of {arr[i]} is {count}");
      }
      count = 0;
      flag = true;
    }
  }

}