class Vehicle
{
  protected double distanceTraveled = 0.0;
  protected double hoursDriven = 0.0;
  protected double fuelConsumed = 0.0;

  public Vehicle(double distanceTraveled, double hoursDriven, double fuelConsumed)
  {
    this.distanceTraveled = distanceTraveled;
    this.hoursDriven = hoursDriven;
    this.fuelConsumed = fuelConsumed;

  }

  public void AverageSpeed()
  {
    if (hoursDriven > 0)
    {
      double averageSpeed = distanceTraveled / hoursDriven;
      Console.WriteLine($"Average Speed: {averageSpeed} units/hour");
    }
    else
    {
      Console.WriteLine("Hours driven must be greater than zero to calculate average speed.");
    }
  }
  public void Milage()
  {
    if (fuelConsumed > 0)
    {
      double speed = distanceTraveled / fuelConsumed;
      Console.WriteLine($"Speed: {speed} units/liter");
    }
    else
    {
      Console.WriteLine("Fuel consumed must be greater than zero to calculate speed.");
    }

    Console.WriteLine("Vehicles milage method called.");
  }
  public virtual void DisplayInfo()
  {
    Console.WriteLine($"Distance Traveled: {distanceTraveled} units, Hours Driven: {hoursDriven} hours, Fuel Consumed: {fuelConsumed} liters");
    Console.WriteLine("Vehicles virtual method called.");
  }


}