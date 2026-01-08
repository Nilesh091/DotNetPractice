using System.Net.NetworkInformation;

public class IncomeTransaction : Transaction
{
  public string Source { get; set; }
  public IncomeTransaction(int id, DateTime date, decimal amount, string description, string source) : base(id, date, amount, description)
  {
    this.Source = Source;
  }
  public override string GetSummery()
  {
    return $"[INCOME] ₹{Amount} from {Source} | {Description} on {Date:d}";
  }
}