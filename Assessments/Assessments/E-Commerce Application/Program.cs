using System;


public class InsufficientWalletBalanceException : Exception
{
  public InsufficientWalletBalanceException(string message) : base(message)
  {
  }
}

class EcommerceShop
{
  public string UserName { get; set; }
  public double WalletBalance { get; set; }
  public double TotalPurchaseAmount { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Program p = new Program();

    Console.WriteLine("Enter User Name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter Wallet Balance:");
    double balance = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter Total Purchase Amount:");
    double amount = double.Parse(Console.ReadLine());

    try
    {
      EcommerceShop shop = p.MakePayment(name, balance, amount);
      Console.WriteLine("Payment successful");
    }
    catch (InsufficientWalletBalanceException ex)
    {
      Console.WriteLine(ex.Message);
    }
  }

  public EcommerceShop MakePayment(string name, double balance, double amount)
  {
    if (balance < amount)
    {
      throw new InsufficientWalletBalanceException(
          "Insufficient balance in your digital wallet"
      );
    }

    EcommerceShop shop = new EcommerceShop
    {
      UserName = name,
      WalletBalance = balance,
      TotalPurchaseAmount = amount
    };

    return shop;
  }
}

