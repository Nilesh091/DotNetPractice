using System.Text.RegularExpressions;
namespace LogProcessing
{
  class LogParser
  {
    private readonly string validLineRegexPattern = @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";
    private readonly string splitLineRegexPattern = @"<\*\*\*>|<====>|<\^\*>";
    private readonly string quotedPasswordRegexPattern = @"(?i)""[^""]*password[^""]*""";
    private readonly string endOfLineRegexPattern = @"end-of-line\d+";
    private readonly string weakPasswordRegexPattern = @"password[a-zA-Z0-9]+";

    public bool IsValidLine(string text)
    {
      return Regex.IsMatch(text, validLineRegexPattern);
    }

    public string[] SplitLogLine(string text)
    {
      return Regex.Split(text, splitLineRegexPattern);
    }

    public int CountQuotedPasswords(string lines)
    {
      return Regex.Matches(lines, quotedPasswordRegexPattern).Count;
    }
    public string RemoveEndOfLineText(string line)
    {
      return Regex.Replace(line, endOfLineRegexPattern, "");
    }
    public string[] ListLinesWithPasswords(string[] lines)
    {
      List<string> result = new List<string>();

      foreach (var line in lines)
      {
        Match m = Regex.Match(line, weakPasswordRegexPattern);
        if (m.Success)
          result.Add(m.Value + ": " + line);
        else
          result.Add("--------: " + line);
      }
      return result.ToArray();
    }


  }
}