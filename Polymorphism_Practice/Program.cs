// See https://aka.ms/new-console-template for more information
class Program
{
  static void Main(string[] args)
  {
    //Furniture f2 - new Furniture(); // Cannot create an instance of the abstract class Furniture
    Furniture furniture;

    // Create an instance of BookSelves
    furniture = new BookSelves();

    // Accept details for BookSelves
    furniture.Accept();

    // Display information for BookSelves
    furniture.DisplayInfo();
    furniture.DefaultMethod();
    //furniture.SpecificMethod();
    //Because SpecificMethod is not accessible through Furniture reference
  }
}
