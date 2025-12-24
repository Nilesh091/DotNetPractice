class Car : Vehicle
{
  public Car(double distanceTraveled, double hoursDriven, double fuelConsumed) : base(distanceTraveled, hoursDriven, fuelConsumed)
  {

  }
  public override void DisplayInfo()
  {
    Console.WriteLine("Car Information:");
    base.DisplayInfo();
  }
  public new void Milage()
  {
    if (fuelConsumed > 0)
    {
      double milage = (distanceTraveled / fuelConsumed) * 1.2; // Cars are generally more efficient
      Console.WriteLine($"Car Milage: {milage} units/liter");
    }
    else
    {
      Console.WriteLine("Fuel consumed must be greater than zero to calculate car milage.");
    }
  }
}