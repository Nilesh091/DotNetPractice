class BookSelves : Furniture
{
  public override void Accept()
  {
    Console.WriteLine("Accepting BookSelves details.");
    // Implementation for accepting BookSelves details
    // e.g., reading input values for num, color, width, height
    Console.WriteLine("Enter number of shelves of the BookSelves:");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter color of the BookSelves:");
    color = Console.ReadLine();
    Console.WriteLine("Enter width and height of the BookSelves:");
    width = Convert.ToInt32(Console.ReadLine());
    
    height = Convert.ToInt32(Console.ReadLine());


  }
  public override void DisplayInfo()
  {
    Console.WriteLine("Displaying BookSelves information.");
    // Implementation for displaying BookSelves information
    Console.WriteLine($"Number: {num}, Color: {color}, Width: {width}, Height: {height}");
  }
  public void SpecificMethod()
  {
    Console.WriteLine("This is a specific method in the BookSelves class.");
  }

}