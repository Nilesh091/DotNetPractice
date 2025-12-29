using System.Data;

class MergeTwoSortedArray
{
  public static int[] mergeTwoSortedArray(int[] arr1, int[] arr2)
  {
    int n1 = arr1.Length;
    int n2 = arr2.Length;
    int mainArrayLength = n1 + n2;
    int[] ans = new int[mainArrayLength];
    int ind1 = 0;
    int ind2 = 0;
    int curInd = 0;
    while (ind1 < n1 && ind2 < n2)
    {
      if (arr1[ind1] < arr2[ind2])
      {
        ans[curInd++] = arr1[ind1++];

      }
      else
      {
        ans[curInd++] = arr2[ind2++];
      }
    }
    while (ind1 < n1)
    {
      ans[curInd++] = arr1[ind1++];
    }
    while (ind2 < n2)
    {
      ans[curInd++] = arr1[ind2++];
    }

    return ans;
  }

}