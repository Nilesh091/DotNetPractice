class PasswordMismatchException : Exception
{
  public PasswordMismatchException() : base(message)
  {

  }
}
class User
{
  public string Name { get; set; }
  public string Password { get; set; }
  public string ConfirmationPassword { get; set; }
}
class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter username:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter password:");
    string password = Console.ReadLine();
    Console.WriteLine("Reenter password:");
    string confPass = Console.ReadLine();
    try
    {
      ValidatePassword(name, password, confirmationPassword);
    }
    catch (PasswordMismatchException ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
  public User ValidatePassword(string name, string password, string confirmationPassword)
  {
    if (!password.Equals(confirmationPassword))
    {
      throw new PasswordMismatchException("Password entered does not match.");
    }
    User user = new User()
    {
      Name = name,
      Password = password,
      ConfirmationPassword = confirmationPassword
    };
    return user;
  }
}