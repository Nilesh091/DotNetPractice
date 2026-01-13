using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Text.Json;

[Serializable]
public class Album
{
  public string Track { get; set; }
  public string Artist { get; set; }
}
class Program
{
  public static void Main()
  {
    Album alb = new Album();
    alb.Track = "The Way You Look Tonight";
    alb.Artist = "Frank Sinatra";

    // string json = JsonSerializer.Serialize(alb);
    // File.WriteAllText("album.json", json);
    // Console.WriteLine("Serialized Successfully");
    Deserialize();
  }

  public static void Deserialize()
  {
    Album alb = JsonSerializer.Deserialize<Album>(File.ReadAllText("album.json"));
    Console.WriteLine("Track: " + alb.Track + "  Artist: " + alb.Artist);
  }
}