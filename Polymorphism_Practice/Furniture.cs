abstract class Furniture
{
  protected int num;
  protected string color;
  protected int width;
  protected int height;


  public abstract void Accept();
  public abstract void DisplayInfo();
  public void DefaultMethod()
  {
    Console.WriteLine("This is a default method in the Furniture class.");
  }
}