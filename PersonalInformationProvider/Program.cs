// See https://aka.ms/new-console-template for more information
class Program
{
  public static void Main(string[] args)
  {
    Person person = new Person();
    Console.WriteLine("Enter Your name:");
    person.Name = Console.ReadLine();
    Console.WriteLine("Enter Your age:");
    person.Age = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Your address:");
    person.Address = Console.ReadLine();

    Console.WriteLine("\nDisplaying Information:");
    Console.WriteLine("Name: " + person.Name);
    Console.WriteLine("Age: " + person.Age);
    Console.WriteLine("Address: " + person.Address);
  }
}
