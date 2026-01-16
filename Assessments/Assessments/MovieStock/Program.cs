using System.Diagnostics;

class Movie
{
  public string Title { get; set; }
  public string Artist { get; set; }
  public string Genre { get; set; }
  public int rating { get; set; }
}

class Program
{
  public static List<Movie> movieList = new List<Movie>();
  public static void Main()
  {
    Console.WriteLine("Enter a number of movies to be added.");
    int n = Convert.ToInt16(Console.WriteLine());
    for (int i = 0; i < n; i++)
    {
      string st = Console.ReadLine();
      AddMovie(st);
    }
    Console.WriteLine("Enter the genre:");
    string gen = Console.WriteLine();
    List<Movie> moviesGenre = ViewMoviesByGenre(gen);
    foreach (var item in moviesGenre)
    {
      Console.WriteLine("Title: " + item.Title + " Artist: " + item.Artist + " Genre: " + item.Genre + "Rating: " + item.rating);
    }

    List<Movie> moviesRating = ViewMoviesByRatings();

    foreach (var item in moviesRating)
    {
      Console.WriteLine("Title: " + item.Title + " Artist: " + item.Artist + " Genre: " + item.Genre + "Rating: " + item.rating);
    }
  }

  public static void AddMovie(string str)
  {
    string[] strarr = str.Split();
    movieList.Add(new Movie() { Title = strarr[0], Artist = strarr[1], Genre = strarr[2], rating = Convert.ToInt32(strarr[3]) });
  }
  public static List<Movie> ViewMoviesByGenre(string genre)
  {
    return movieList.Where(s => s.Genre = genre);
  }

  public static List<Movie> ViewMoviesByRatings()
  {
    return movieList.OrderBy(s => s.rating);
  }
}