using System.Text.RegularExpressions;
class Program
{
  public static void Main()
  {
    MatchCollection matches = Regex.Matches("10 20 30", @"\d+");
    foreach (var v in matches)
    {
      Console.WriteLine(v);
    }

  }
}