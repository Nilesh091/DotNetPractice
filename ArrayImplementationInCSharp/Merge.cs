using System.Data;

class Merge
{
  public static void MergedArray(int[] arr, int left, int mid, int right)
  {
    int n1 = mid - left + 1;
    int n2 = right - mid;

    int[] L = new int[n1];
    int[] R = new int[n2];

    for (int i = 0; i < n1; i++)
    {
      L[i] = arr[left + i];
    }
    for (int i = 0; i < n2; i++)
    {
      R[i] = arr[mid + 1 + i];
    }

    int lIndex = 0;
    int rIndex = 0;
    int curInd = left;

    while (lIndex < n1 && rIndex < n2)
    {
      if (L[lIndex] < R[rIndex])
      {
        arr[curInd++] = L[lIndex++];
      }
      else
      {
        arr[curInd++] = R[rIndex++];
      }
    }
    while (lIndex < n1)
    {
      arr[curInd++] = L[lIndex++];
    }
    while (rIndex < n2)
    {
      arr[curInd++] = R[rIndex++];
    }
  }
}