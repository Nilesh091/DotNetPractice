public class ExpenseTransaction : Transaction
{
  public string Catagory { get; set; }
  public ExpenseTransaction(int id, DateTime date, decimal amount, string description, string catagory)
    : base(id, date, amount, description)
  {
    this.Catagory = catagory;
  }
  public override string GetSummery()
  {
    return $"[Expense] ₹{Amount} for {Catagory} | {Description} on {Date:d}";
  }
}