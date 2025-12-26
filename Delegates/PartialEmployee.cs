public partial class PartialEmployee
{
   public string firstName { get; set; }
    public string lastName { get; set; }
    public double salary { get; set; }
    public string gender { get; set; }
    

    // define partial method  
    partial void PrintName();
}