class InvalidInputException : Exception
{
  public InvalidInputException()
  {
    Console.WriteLine("Invalid Input Entered! Please enter either 'C' or 'F'.");
  }
}
class Program
{
  public static decimal TempConvert(decimal n, string s)
  {
    if (s == "C")
      return (n * 9 / 5) + 32;
    else if (s == "F")
      return ((n - 32) * 5) / 9;
    else throw new InvalidInputException();
  }
  static void Main(string[] args)
  {
    try
    {
      Console.Write("Enter Temperature: ");
      decimal n = Convert.ToDecimal(Console.ReadLine());
      Console.Write("Enter C for Celsius or F for Fahrenheit: ");
      string s = Console.ReadLine();
      Console.WriteLine($"{TempConvert(n, s):F2}");

    }
    catch (InvalidInputException f)
    {
      Console.WriteLine(f.Message);
      Console.WriteLine("User Defined Exception Occured!");
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
      Console.WriteLine("System Exception Occured!");
    }
    finally
    {
      Console.ReadKey();
    }

  }
}
