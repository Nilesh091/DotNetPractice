class StringConverter
{
  public string ConvertString(string input)
  {
    // Example conversion: reverse the string
    return input.ToUpper();
  }
  public string ConvertString(string input, bool toLower)
  {
    // Example conversion: convert to lower case if toLower is true
    return input.ToLower();
  }
  public string ConvertString(string input, int TitleCase)
  {
    // Example conversion: repeat the string repeatCount times
    return input.Substring(0, 1).ToUpper() + input.Substring(1).ToLower();
  }
}