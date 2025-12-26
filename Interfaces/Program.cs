class Program
{
  static void Main(string[] args)
  {
    CreditCardPayment ccp = new CreditCardPayment();
    ccp.pay(100);
    ccp.refund(100);
  }
}
