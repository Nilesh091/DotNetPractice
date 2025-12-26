class WeightConverter : Converter
{
  public override double Convert(double value, string fromUnit, string toUnit)
  {
    //gram to kilogram
    if (fromUnit == "Gram" && toUnit == "Kilogram")
      return value / 1000;
    //kilogram to gram
    else if (fromUnit == "Kilogram" && toUnit == "Gram")
      return value * 1000;
    //Pounds to Ounces
    else if (fromUnit == "Pound" && toUnit == "Ounce")
      return value * 16;
    //Ounces to Pounds
    else if (fromUnit == "Ounce" && toUnit == "Pound")
      return value / 16;
    return value;
  }
  public override double Convert(double value, string fromUnit)
  {
    // Not implemented for single unit conversion
    // default conversion to kilogram.
    if (fromUnit == "Gram")
      return value / 1000;
    else if (fromUnit == "Pound")
      return value * 0.453592;
    else if (fromUnit == "Ounce")
      return value * 0.0283495;
    return value;
  }
}