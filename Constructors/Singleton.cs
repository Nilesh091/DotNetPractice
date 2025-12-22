class Singleton
{
  private static Singleton instance;
  private Singleton() { }// Private constructor to prevent instantiation from outside
  public static Singleton GetInstance()
  {
    if (instance == null)
    {
      instance = new Singleton();
    }
    return instance;
  }
}