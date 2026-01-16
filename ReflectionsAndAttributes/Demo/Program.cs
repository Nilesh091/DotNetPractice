
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
public class DebugInfo : Attribute
{
  private int bugnum;
  private string developer;
  private string lastReview;
  private string message;
  public DebugInfo(int bug, string dev, string last)
  {
    this.bugnum = bug;
    this.developer = dev;
    this.lastReview = last;
  }
  public int BugNo
  {
    get
    {
      return bugnum;
    }
  }
  public string Developer
  {
    get
    {
      return developer;
    }
  }
  public string LastReview
  {
    get
    {
      return lastReview;
    }
  }

  public string Message
  {
    set
    {
      message = value;
    }
    get
    {
      return message;
    }
  }
}


[DebugInfo(45, "Zara Ali", "12/12/2012", Message = "Return type missmatch")]
[DebugInfo(65, "Zara Ali", "19/12/2012", Message = ",,,..lll")]
class Rectangle
{
  protected double length;
  protected double width;

  public Rectangle(double l, double w)
  {
    this.length = l;
    this.width = w;
  }
  [DebugInfo(55, "ZaraAli", "19/10/2012", Message = "Return Type Missmatch")]
  public double GetArea()
  {
    return length * width;
  }
  [DebugInfo(56, "ZaraAli", "19/10/2012")]
  public void Display()
  {
    Console.WriteLine("Length: " + length);
    Console.WriteLine("Width: " + width);
    Console.WriteLine("Area: " + GetArea());

  }

}
class Program
{
  public static void Main()
  {

  }
}