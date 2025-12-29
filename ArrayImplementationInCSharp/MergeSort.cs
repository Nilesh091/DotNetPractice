using System.Net.Http.Headers;
using System.Security.AccessControl;

class MergeSort
{
  public static void MS(int[] arr, int left, int right)
  {
    if (left < right)
    {
      int mid = left + (right - left) / 2;
      MS(arr, left, mid);
      MS(arr, mid + 1, right);
      Merge.MergedArray(arr, left, mid, right);
    }
  }
  public static void ImplementMergeSort(int[] arr)
  {
    int n = arr.Length;
    int l = 0;
    int r = n - 1;
    // int mid=l+(r-l)/2;
    MS(arr, l, r);

  }
}