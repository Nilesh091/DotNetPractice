using System;

public class CricketMatch
{
  public int[] playerScores = new int[5];
  public int currentIndex = 0;

  public void AddPlayerScore(int score)
  {
    if (score < 0 || score > 50)
    {
      throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
    }

    if (currentIndex >= 5)
    {
      throw new InvalidOperationException("Cannot add more than 5 player scores.");
    }

    playerScores[currentIndex] = score;
    currentIndex++;
  }

  public int CalculateTotalScore()
  {
    int total = 0;
    for (int i = 0; i < currentIndex; i++)
    {
      total += playerScores[i];
    }
    return total;
  }
}

public class Program
{
  public static void Main(string[] args)
  {
    CricketMatch match = new CricketMatch();

    try
    {
      string[] inputs = Console.ReadLine().Split(' ');

      foreach (string s in inputs)
      {
        int score = int.Parse(s);
        match.AddPlayerScore(score);
      }

      int totalScore = match.CalculateTotalScore();
      Console.WriteLine("Total score of the cricket team: " + totalScore);
    }
    catch (InvalidOperationException ex)
    {
      Console.WriteLine("Error: " + ex.Message);
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine("Error: " + ex.Message);
    }
  }
}
