using System;
using System.Collections;
using System.Formats.Tar;

class Album
{
  public string Title { get; set; }
  public string Artist { get; set; }
}
class Program
{
  public static void Main()
  {
    ArrayList al = new ArrayList();

    while (true)
    {
      Console.WriteLine("Enter the Titel of the track");
      string track = Console.ReadLine();
      Console.WriteLine("Enter the Artist name who has produced the track.");
      string artist = Console.ReadLine();
      if (IsValidInput(track) || IsValidInput(artist))
      {
        Console.WriteLine("Enter valid Input!");
        continue;
      }
      if (track == "quit" || track == "quit")
      {
        break;
      }
      Album ab = new Album();
      ab.Artist = artist;
      ab.Title = track;
      al.Add(ab);
    }
  }
  public static bool IsValidInput(string input)
  {
    return string.IsNullOrWhiteSpace(input);
  }
  public static void PrintAlbums(ArrayList alb)
  {
    foreach (Album ab in alb)
    {
      Console.WriteLine("The track is : " + ab.Title + " and the Artist is:" + ab.Artist);
    }
  }
}
