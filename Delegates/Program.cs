class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Single Cast Deligate:---------------------------------");
    SingleClassDelegate obj = new SingleClassDelegate();
    obj.Run();
    Console.WriteLine("\n\nMulti Cast Delegate:----------------------------------");
    MultiCastDelegates obj1 = new MultiCastDelegates();
    obj1.Run();
    Console.WriteLine("\n\nMethod As A Parameter:--------------------------------");
    MethodAsAParameter obj2 = new MethodAsAParameter();
    obj2.Run();
    Console.WriteLine("\n\nDelegare With Parameter:------------------------------");
    DelegareWithParameter obj3 = new DelegareWithParameter();
    obj3.Run();
    Console.WriteLine("\n\nLambda Deligate:--------------------------------------");
    LambdaDeligate obj4 = new LambdaDeligate();
    obj4.Run();
    Console.WriteLine("\n\nAnonymous Deligate:-----------------------------------");
    AnonymousDelegate obj5 = new AnonymousDelegate();
    obj5.Run();

  }
}
