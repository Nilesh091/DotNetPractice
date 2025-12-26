class TempConverter : Converter
{
  public override double Convert(double value, string fromUnit, string toUnit)
  {
    //•	Celsius to Fahrenheit:
    // F = (C × 9/5) + 32
    // •	Fahrenheit to Celsius:
    // C = (F − 32) × 5/9
    // •	Celsius to Kelvin:
    // K = C + 273.15
    // •	Kelvin to Celsius:
    // C = K − 273.15
    if (fromUnit == "Celsius" && toUnit == "Fahrenheit")
      return (value * 9 / 5) + 32;
    else if (fromUnit == "Fahrenheit" && toUnit == "Celsius")
      return (value - 32) * 5 / 9;
    else if (fromUnit == "Celsius" && toUnit == "Kelvin")
      return value + 273.15;
    else if (fromUnit == "Kelvin" && toUnit == "Celsius")
      return value - 273.15;


    return value;
  }
  public override double Convert(double value, string fromUnit)
  {
    // Not implemented for single unit conversion
    //Degfault temt converter celsius
    if (fromUnit == "Celsius")
      return value;
    else if (fromUnit == "Fahrenheit")
      return (value - 32) * 5 / 9;
    else if (fromUnit == "Kelvin")
      return value - 273.15;
    return value;
  }
}