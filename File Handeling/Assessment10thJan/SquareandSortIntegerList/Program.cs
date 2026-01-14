class Program
{
  public static void Main()
  {
    string[] arr = Console.ReadLine().Split(' ');
    List<int> li = new List<int>();
    foreach (var v in arr)
    {
      li.Add(Convert.ToInt32(v) * Convert.ToInt32(v));
    }
    li.Sort();
    foreach (int k in li)
    {
      Console.Write(k + " ");
    }
  }
}