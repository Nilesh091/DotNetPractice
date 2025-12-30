using System;
class StringManipulation
{
  public static void ManipulateString()
  {
    string fname, lname;
    fname = "Avanshikha";
    lname = "Singh";

    char[] letters = { 'h', 'e', 'l', 'l', 'o' };
    string[] sarray = { "hello", "my", "name", "is", "Avanshikha" };

    string fullname = fname + lname;
    System.Console.WriteLine("fullname is : {0}" + fullname);

    string greetings = new string(letters);
    System.Console.WriteLine("greetings: {0}" + greetings);

    string message = String.Join(" ", sarray);
    System.Console.WriteLine("Message: {0}" + message);

    DateTime waiting = new DateTime(2025, 12, 30, 10, 30, 30);
    string chat = String.Format("message sent at {0:t} on {0:D}", waiting);
    System.Console.WriteLine("Message: {0}", chat);


    string str1 = "this is text";
    string str2 = "this is test";

    if (String.Compare(str1, str2) == 0)
    {
      System.Console.WriteLine(str1 + "and" + str2 + "are equal.");
    }
    else
    {
      System.Console.WriteLine(str1 + "and " + str2 + " are not equal.");
    }

    if (str2.Contains("test"))
    {
      System.Console.WriteLine("test was found");
    }


    string str3 = "my name is avanshikha singh";
    System.Console.WriteLine(str3);
    string substr = str3.Substring(11);
    System.Console.WriteLine(substr);

    System.Console.WriteLine("\"hello world\"");
    System.Console.WriteLine("avanshikhaikha\\singh\\Rajput");
    System.Console.WriteLine(@"avanshikhaikha\singh\Rajput");
    //@ is used to format and give same output 
    var messag1 = @"hello Alice,              
  good morning!
  your files have been uploaded sucessfully
  local\disk\c
  thanks.";
    System.Console.WriteLine(messag1);

    var name = "Alice";
    var greet = String.Format("Hello {0}, {1}!", name, "good morning");
    System.Console.WriteLine(greet);

    var text = "ABCDEFGHIJKLMNOP";
    var Sub_text = text.Substring(6, 5);
    System.Console.WriteLine(Sub_text);
    var text3 = "helLo wOrld";
    System.Console.WriteLine(text3.ToUpper());
    System.Console.WriteLine(text3.ToLower());
    var text4 = "helLo         wOrld             ";
    System.Console.WriteLine(text4.Trim());
    var csv = "Alice,dustin,holly,lucas,max";
    var names = csv.Split(',');
    for (var i = 0; i < names.Length; i++)
    {
      System.Console.WriteLine(names[i]);
    }

    var greet3 = "Hello World ! welcome!";
    var index = greet3.IndexOf("el");
    System.Console.WriteLine(index);
    var index1 = greet3.LastIndexOf("el");
    System.Console.WriteLine(index1);


    Console.ReadKey();
  }
}