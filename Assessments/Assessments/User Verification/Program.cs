
using System;

namespace UserVerificationApp
{

  public class InvalidPhoneNumberException : Exception
  {
    public InvalidPhoneNumberException(string message) : base(message)
    {
    }
  }


  class User
  {
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Program p = new Program();

      Console.WriteLine("Enter Name:");
      string name = Console.ReadLine();

      Console.WriteLine("Enter Phone Number:");
      string phoneNumber = Console.ReadLine();

      try
      {
        User user = p.ValidatePhoneNumber(name, phoneNumber);
        Console.WriteLine("Phone number verified successfully");
      }
      catch (InvalidPhoneNumberException ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    public User ValidatePhoneNumber(string name, string phoneNumber)
    {
      if (phoneNumber.Length != 10)
      {
        throw new InvalidPhoneNumberException("Invalid phone number");
      }

      User user = new User
      {
        Name = name,
        PhoneNumber = phoneNumber
      };

      return user;
    }
  }
}
