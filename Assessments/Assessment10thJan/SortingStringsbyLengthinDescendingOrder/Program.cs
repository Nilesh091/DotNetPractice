using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

class Program
{
  public static void Method2()
  {
    string[] arr = Console.ReadLine().Split(' ');
    Dictionary<string, int> dict = new Dictionary<string, int>();
    foreach (var item in arr)
    {
      dict[item] = item.Length;
    }

    PriorityQueue<string, int> pq = new PriorityQueue<string, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
    foreach (var item in dict)
    {
      pq.Enqueue(item.Key, item.Value);
    }
    StringBuilder sb = new StringBuilder();
    while (pq.Count != 0)
    {

      sb.Append(pq.Dequeue());
      sb.Append(" ");
    }
    Console.WriteLine(sb.ToString());
  }
  public static void Main()
  {
    string[] arr = Console.ReadLine().Split(' ');
    arr.Sort((x, y) => y.Length.CompareTo(x.Length));
    foreach (string s in arr) Console.Write(s + " ");
    int[] arr1 = { 5, 4, 7, 1, 8, 9, 3 };

    Method2();
  }
}