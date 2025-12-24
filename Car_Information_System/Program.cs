// See https://aka.ms/new-console-template for more information
class Program
{
  static void Main(string[] args)
  {
    Car myCar = new Car("Toyota", "Camry", 2015);
    myCar.DisplayDetails();
    myCar.DisplayAge();
  }
}
