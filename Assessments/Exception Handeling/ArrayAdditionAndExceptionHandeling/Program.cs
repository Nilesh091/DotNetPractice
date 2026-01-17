using System.Diagnostics.Contracts;
class notSameLengthException : Exception
{
  public notSameLengthException()
  {
    Console.WriteLine("The length of the two arrays are different");
  }
}
class Program
{
  public static void Main()
  {
    String[] stringArr1 = Console.ReadLine().Split(" ");
    String[] stringArr2 = Console.ReadLine().Split(" ");

    int[] arr1 = new int[stringArr1.Length];
    for (int i = 0; i < stringArr1.Length; i++)
      arr1[i] = Convert.ToInt32(stringArr1[i]);
    int[] arr2 = new int[stringArr2.Length];
    for (int j = 0; j < stringArr2.Length; j++)
      arr2[j] = Convert.ToInt32(stringArr2[j]);
    try
    {
      if (arr2.Length != arr1.Length)
      {
        throw new notSameLengthException();
      }
    }
    catch (notSameLengthException e)
    {
      Console.WriteLine(e.Message);
      return;
    }
    int[] sumArr = new int[arr1.Length];
    for (int i = 0; i < arr1.Length; i++)
    {
      sumArr[i] = arr1[i] + arr2[i];
    }
    try
    {
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("The value at index " + n + " is: " + sumArr[n]);
    }
    catch (IndexOutOfRangeException)
    {
      Console.WriteLine("The Index is out of range");
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
    finally
    {
      Console.WriteLine("The Program is exicued Successfully ");
    }
  }
}