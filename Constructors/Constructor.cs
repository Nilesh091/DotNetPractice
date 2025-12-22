class Constructor
{
  int n;
  public Constructor()
  {
    Console.WriteLine("Basic Constructor Is called");
    this.n = 5;      // This is a constructor
  }
  //Parameterized Constructor
  public Constructor(string name)
  {
    Console.WriteLine("Parameterized Constructor Is called: " + name);
  }
  //Copy Constructor
  public Constructor(Constructor obj)
  {
    Console.WriteLine("Copy Constructor Is called");
    Console.WriteLine("Value of n in copied object: " + obj.n);
  }

}