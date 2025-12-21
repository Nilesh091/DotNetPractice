using System;

class CelsiustoFahrenheitConversion
{
  public void convertTemp()
  {
    // Read Celsius temperature
    double celsius = double.Parse(Console.ReadLine());

    // Convert to Fahrenheit
    double fahrenheit = (celsius * 9 / 5) + 32;

    // Print results
    Console.WriteLine("Temperature in Celsius: " + celsius);
    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
  }
}
