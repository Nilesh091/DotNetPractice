using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
class Program
{
  public static SortedDictionary<string, long> dictionary = new SortedDictionary<string, long>();

  public static void Main()
  {
    Console.WriteLine("Enter number of Items:");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine("Enter the product Name: ");
      string item = Console.ReadLine();
      Console.WriteLine("Enter sold count.");
      long count = Convert.ToInt64(Console.ReadLine());

      dictionary.Add(item, count);
    }
    Console.WriteLine("Enter sold count to search:");
    long searchCount = Convert.ToInt64(Console.ReadLine());
    SortedDictionary<string, long> findElementDetails = FindElementDetails(searchCount);
    if (findElementDetails.Count == 0)
    {
      Console.WriteLine("Item Not found");
    }
    else
    {
      Console.WriteLine("Item Found");
      foreach (var v in findElementDetails)
      {
        Console.WriteLine(v.Key + " - " + v.Value);
      }
    }

    List<string> findMinandMaxSolditems = FindMinandMaxSolditems();
    Console.WriteLine("Minimum Sold Items: " + findMinandMaxSolditems[0]);
    Console.WriteLine("Maximum Sold Items: " + findMinandMaxSolditems[1]);

    Dictionary<string, long> sortByCount = SortByCount();
    Console.WriteLine("Items sorted by sold count:");
    foreach (var v in sortByCount)
    {
      Console.WriteLine("Item: " + v.Key + " Unit Sold: " + v.Value);
    }

  }
  public static SortedDictionary<string, long> FindElementDetails(long count)
  {
    SortedDictionary<string, long> dict2 = new SortedDictionary<string, long>();
    foreach (var v in dictionary)
    {
      if (v.Value == count)
      {
        dict2.Add(v.Key, v.Value);
      }
    }
    return dict2;
  }

  public static List<string> FindMinandMaxSolditems()
  {
    var min = dictionary.MaxBy(s => s.Value);
    var max = dictionary.MinBy(s => s.Value);
    List<string> li = new List<string>();
    li.Add(min.Key);
    li.Add(max.Key);
    return li;
  }

  public static Dictionary<string, long> SortByCount()
  {
    return dictionary.OrderBy(s => s.Value).ToDictionary(x => x.Key, x => x.Value);
  }


}