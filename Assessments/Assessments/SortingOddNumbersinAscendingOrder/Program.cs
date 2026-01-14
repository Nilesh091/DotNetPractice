class Program
{
  private static void Display(List<int> li)
  {
    foreach (var v in li) Console.WriteLine(v);
  }
  private static List<int> GetOddNumbers(List<int> numbers)
  {
    List<int> subAns = new List<int>();
    foreach (var v in numbers)
    {
      if (v % 2 != 0)
      {
        subAns.Add(v);
      }
    }
    return subAns;

  }
  private static List<int> ParseIntegers(string st)
  {
    List<int> li = new List<int>();
    string[] stringIntArr = st.Split(',');
    foreach (var v in stringIntArr)
    {
      li.Add(Convert.ToInt32(v));
    }
    return li;
  }
  public static void Main()
  {
    Console.WriteLine("Enter a string of numbers separated with comma, Semicolon or whitespaces");
    string st = Console.ReadLine();
    List<int> arrayofIntegers = ParseIntegers(st);
    List<int> oddArray = GetOddNumbers(arrayofIntegers);
    oddArray.Sort();// Sorting odd Array
    Display(oddArray);

  }
}