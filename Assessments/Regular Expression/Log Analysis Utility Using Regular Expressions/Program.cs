using System;
using System.Collections.Generic;
using LogProcessing;

class Program
{
  public static void Main()
  {
    LogParser parser = new LogParser();

    // ----- Task 1: IsValidLine -----
    Console.WriteLine("Task 1: Validate Log Line");
    Console.WriteLine(parser.IsValidLine("[INF] Application started")); // true
    Console.WriteLine(parser.IsValidLine("INF Application started"));   // false
    Console.WriteLine();

    // ----- Task 2: SplitLogLine -----
    Console.WriteLine("Task 2: Split Log Line");
    string log = "[INF] User login<***>Session created<====>Access granted";
    string[] parts = parser.SplitLogLine(log);

    foreach (var p in parts)
      Console.WriteLine(p);
    Console.WriteLine();

    // ----- Task 3: CountQuotedPasswords -----
    Console.WriteLine("Task 3: Count Quoted Passwords");
    string textBlock =
        "User said \"password123 is weak\"\n" +
        "Admin noted \"PASSWORD456 expired\"\n" +
        "No issue found";

    Console.WriteLine(parser.CountQuotedPasswords(textBlock)); // 2
    Console.WriteLine();

    // ----- Task 4: RemoveEndOfLineText -----
    Console.WriteLine("Task 4: Remove End-of-Line Marker");
    string line = "Transaction completed successfully end-of-line456";
    Console.WriteLine(parser.RemoveEndOfLineText(line));
    Console.WriteLine();

    // ----- Task 5: ListLinesWithPasswords -----
    Console.WriteLine("Task 5: List Lines With Passwords");
    string[] lines =
    {
            "User entered password123 during login",
            "System startup completed",
            "Admin reset passwordABC",
            "Backup process finished"
        };

    string[] output = parser.ListLinesWithPasswords(lines);

    foreach (var o in output)
      Console.WriteLine(o);
  }
}
