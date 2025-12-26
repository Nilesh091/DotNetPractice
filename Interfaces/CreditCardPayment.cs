class CreditCardPayment : IPayment
{
  public void pay(double amount)
  {
    Console.WriteLine("Payed {0}", amount);
  }

  public void refund(double amount)
  {
    Console.WriteLine("Refunded {0}", amount - amount * 0.1);
  }
}