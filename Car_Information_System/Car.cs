class Car
{
  public string Make { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }

  public Car(string make, string model, int year)
  {
    this.Model = model;
    this.Make = make;
    this.Year = year;
  }

  public void DisplayDetails()
  {
    Console.WriteLine($"Make: {this.Make}, Model: {this.Model}, Year: {this.Year}");
  }

  public void DisplayAge()
  {
    Console.WriteLine($"Age of the Car: {2024 - this.Year}");
  }
}