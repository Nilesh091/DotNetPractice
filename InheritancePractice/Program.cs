// See https://aka.ms/new-console-template for more information
using System;
class Program
{
  static void Main(string[] args)
  {
    // Employee emp = new Employee(1, "John Doe", "Software Engineer", 75000m);
    // Console.WriteLine(emp.ToString());
    // // Same function is done if we just write:
    // Console.WriteLine(emp);
    // // if we dont override ToString() method, it will print the class name

    Car myCar = new Car(300.0, 5.0, 20.0);
    myCar.DisplayInfo();
    myCar.AverageSpeed();
    myCar.Milage();

    Console.WriteLine("---------- Using Vehicle reference to Car object --------");
    Vehicle myVehicle = new Car(300.0, 5.0, 20.0);
    myVehicle.DisplayInfo(); // Calls Car's DisplayInfo method because of polymorphism
    myVehicle.AverageSpeed(); // Calls Vehicle's AverageSpeed method  because ofpolymorphism
    myVehicle.Milage(); // Calls Vehicle's Milage method

  }
}
