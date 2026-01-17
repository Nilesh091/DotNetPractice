class ConstructionEstimateException : Exception
{
  public ConstructionEstimateException() : base(message)
  {

  }
}

class EstimateDetails
{
  public float ConstructionArea { get; set; }
  public float SiteArea { get; set; }

}

class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter ConstructionArea:");
    float carea = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Enter SiteArea:");
    float sarea = Convert.ToDecimal(Console.ReadLine());
    try
    {
      ValidateConstructionEstimate(carea, sarea);
      Console.WriteLine("Object created successfully.");
    }
    catch (ConstructionEstimateException ex)
    {
      Console.WriteLine(ex.Message);
    }


  }

  public EstimateDetails ValidateConstructionEstimate(float constructionArea, float siteArea)
  {
    if (constructionArea > siteArea)
    {
      throw new ConstructionEstimateException("Sorry your Construction Estimate is not approved");
    }
    EstimateDetails ed = new EstimateDetails()
    {
      ConstructionArea = constructionArea,
      SiteArea = siteArea
    };
    return ed;
  }
}