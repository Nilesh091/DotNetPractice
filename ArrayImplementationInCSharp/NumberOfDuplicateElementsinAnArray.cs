

class NumberOfDuplicateElementsinAnArray
{
  public static int returnCountduplicateElements(int[] arr)
  {
    int count = 0;
    int n = arr.Length;
    for (int i = 0; i < n; i++)
    {
      bool isDuplicate = false;

      //Check for further duplicacy
      for (int j = i + 1; j < n; j++)
      {
        if (arr[i] == arr[j])
        {
          isDuplicate = true;
          break;
        }
      }
      //If chaecked previously
      for (int k = 0; i < i; k++)
      {
        if (arr[k] == arr[i])
        {
          isDuplicate = false;
          break;
        }
      }
      if (isDuplicate) count++;
    }
    return count;
  }
}