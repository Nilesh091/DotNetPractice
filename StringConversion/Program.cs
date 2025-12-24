// See https://aka.ms/new-console-template for more information
class Program
{
  static void Main(string[] args)
  {
    StringConverter converter = new StringConverter();
    string result = converter.ConvertString("Hello, World!");
    Console.WriteLine(result);
    string lowerResult = converter.ConvertString("HELLO WORLD!", true);
    Console.WriteLine(lowerResult);
    string titleResult = converter.ConvertString("hello world", 3);
    Console.WriteLine(titleResult);
  }
}
