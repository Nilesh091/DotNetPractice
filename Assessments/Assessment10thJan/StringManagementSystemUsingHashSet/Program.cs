class Program
{
  public static void Main()
  {
    HashSet<string> hs = new HashSet<string>();

    while (true)
    {
      Console.WriteLine("1: Add new string \n 2: Read all String \n 3:Update String \n 4:Delete \n 5: Exit");
      int n = Convert.ToInt32(Console.ReadLine());

      if (n == 1)
      {
        string st = Console.ReadLine();
        if (hs.Contains(st))
        {
          Console.WriteLine("The String Already Exist .");
          continue;
        }
        hs.Add(st);

      }
      else if (n == 2)
      {
        Console.WriteLine("The strings present in the hashset ");
        foreach (var v in hs)
        {
          Console.WriteLine(v);
        }
      }
      else if (n == 3)
      {
        Console.WriteLine("Enter the string which has to update:");
        string st = Console.ReadLine();
        Console.WriteLine("Upadted String: ");
        string st2 = Console.ReadLine();
        if (hs.Contains(st))
        {
          hs.Remove(st);
          hs.Add(st2);
        }
        else
        {
          Console.WriteLine("The entered String doesnot exist:");
        }
      }
      else if (n == 4)
      {
        Console.WriteLine("Enter the string to remove from the Hashset: ");
        string st = Console.ReadLine();
      }
      else if (n == 5)
      {
        break;
      }
    }
  }
}