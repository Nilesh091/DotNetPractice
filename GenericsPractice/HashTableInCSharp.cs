
using System;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
class HashTableInCSharp
{
  public static void Hash()
  {
    Hashtable ht = new Hashtable();
    ht.Add("1", "One");
    ht.Add("2", "Two");
    ICollection key = ht.Keys;
    foreach (var k in key)
      Console.WriteLine(k + ":" + ht[k]);
    ICollection value = ht.Values;
    foreach (var v in value)
      Console.WriteLine(v);

    Console.WriteLine(ht.ContainsKey("1"));
    Console.WriteLine(ht.ContainsValue("One"));
    Console.WriteLine(ht["1"]);
    ht.Remove("1");

    //Sorted list

    SortedList<String, String> sl = new SortedList<String, String>();
    sl.Add("1", "One");
    sl.Add("2", "Two");
    sl.Add("3", "Three");
    sl.Add("4", "Four");
    sl.Add("9", "Nine");
    sl.Add("5", "Five");
    sl.Add("6", "Six");
    sl.Add("7", "Seven");
    sl.Add("8", "Eight");

    // foreach (KeyValuePair<string, string> kvp in sl)
    // {
    //   Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
    // }
    // var values = sl.Values;
    // foreach (var v in values)
    //   Console.WriteLine(v);
    // foreach (var k in sl.Keys)
    //   Console.WriteLine(k);

    // for (int i = 0; i < sl.Count; i++)// generate wrong  why? no idea
    //   Console.WriteLine(sl.GetKey(i));


    // SortedList<int, String> sortedlist = new SortedList<int, string>();
    // sortedlist.Add(250, "Apple");
    // sortedlist.Add(50, "Banana");
    // sortedlist.Add(150, "Grapes");

    // foreach (var v in sortedlist)
    // {
    //   Console.WriteLine(v);
    // }
  }
}