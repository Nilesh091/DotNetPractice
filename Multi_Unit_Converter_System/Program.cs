// See https://aka.ms/new-console-template for more information
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Welcome to the Multi-Unit Converter System!");

    Console.WriteLine("Select the type of conversion do you need:");
    Console.WriteLine("1. Length");
    Console.WriteLine("2. Weight");
    Console.WriteLine("3. Temperature");
    string choice = Console.ReadLine();
    switch (choice)
    {
      case "1":
        LengthConverter lengthConverter = new LengthConverter();
        Console.WriteLine("Enter the length to convert:");
        double lengthValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the unit to convert from: eg (Meter, Kilometer, Mile, Foot)");
        string fromUnit = Console.ReadLine();
        Console.WriteLine("Enter the unit to convert to:(Meter, Kilometer, Mile, Foot)");
        string toUnit = Console.ReadLine();
        double result;
        if (toUnit == null)
        {
          result = lengthConverter.Convert(lengthValue, fromUnit);
        }
        else
        {
          result = lengthConverter.Convert(lengthValue, fromUnit, toUnit);
        }

        Console.WriteLine($"Result: {result}");
        break;
      case "2":
        WeightConverter weightConverter = new WeightConverter();
        Console.WriteLine("Enter the weight to convert:");
        double weightValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the unit to convert from: eg(Kilogram, Gram, Pound, Ounce)");
        string fromUnitW = Console.ReadLine();
        Console.WriteLine("Enter the unit to convert to:eg(Kilogram, Gram, Pound, Ounce)");
        string toUnitW = Console.ReadLine();
        if (toUnitW == null)
        {
          double resultW1 = weightConverter.Convert(weightValue, fromUnitW);
          Console.WriteLine($"Result: {resultW1}");
          break;
        }
        double resultW = weightConverter.Convert(weightValue, fromUnitW, toUnitW);
        Console.WriteLine($"Result: {resultW}");
        break;
      case "3":
        TempConverter tempConverter = new TempConverter();
        Console.WriteLine("Enter the temperature to convert:");
        double tempValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the unit to convert from: eg(Celsius, Fahrenheit, Kelvin,)");
        string fromUnitT = Console.ReadLine();
        Console.WriteLine("Enter the unit to convert to: eg(Celsius, Fahrenheit, Kelvin)");
        string toUnitT = Console.ReadLine();
        if (toUnitT == "")
        {
          double resultT1 = tempConverter.Convert(tempValue, fromUnitT);
          Console.WriteLine($"Result: {resultT1}");
          break;
        }
        double resultT = tempConverter.Convert(tempValue, fromUnitT, toUnitT);
        Console.WriteLine($"Result: {resultT}");
        break;
      default:
        Console.WriteLine("Invalid input!");
        return;
    }
  }
}
