class LengthConverter : Converter
{
  public override double Convert(double value, string fromUnit, string toUnit)
  {
    //•	Meters to Kilometers:
    // 1 meter = 0.001 kilometers
    // •	Kilometers to Meters:
    // 1 kilometer = 1000 meters
    // •	Miles to Feet:
    // 1 mile = 5280 feet
    // •	Feet to Miles:
    // 1 foot = 1 / 5280 miles
    if (fromUnit == "Meter" && toUnit == "Kilometer")
      return value * 0.001;
    else if (fromUnit == "Kilometer" && toUnit == "Meter")
      return value * 1000;
    else if (fromUnit == "Mile" && toUnit == "Foot")
      return value * 5280;
    else if (fromUnit == "Foot" && toUnit == "Mile")
      return value / 5280;

    return value;
  }
  public override double Convert(double value, string fromUnit)
  {
    // Not implemented for single unit conversion
    // default conversion to meter.
    if (fromUnit == "Kilometer")
      return value * 1000;
    else if (fromUnit == "Mile")
      return value * 1609.34;
    else if (fromUnit == "Foot")
      return value * 0.3048;
    return value;

  }
}