//using System.Collections.Generic;
class DictionaryInCSharp
{
  public static void Dict()
  {
    Dictionary<int, string> dict = new Dictionary<int, string>();
    dict.Add(1, "One");
    dict.Add(2, "Two");
    foreach (var i in dict)
      Console.WriteLine(i.Key + " " + i.Value);
    foreach (KeyValuePair<int, string> kvp in dict)
    {
      Console.WriteLine(kvp.Key + " " + kvp.Value);
    }
  }
}