class BankAccount
{
  private int balance;

  public void diposit(int amount)
  {
    balance += amount;
  }
  public void withdraw(int amount)
  {
    if (amount < balance) balance -= amount;
    else Console.WriteLine("Insufficient funds");
  }
}

class Animal
{
  public virtual void MakeSound() { }
}
class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Woof!");
  }
}