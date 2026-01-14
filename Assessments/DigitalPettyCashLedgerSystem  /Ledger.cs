public class Ledger<T> where T : Transaction
{
  private readonly List<T> entries = new List<T>();

  public void AddEntry(T entry)
  {
    entries.Add(entry);
  }

  public List<T> GetEntriesByDate(DateTime curdate)
  {
    List<T> ans = new List<T>();
    foreach (var e in entries)
    {
      if (curdate == e.Date) ans.Add(e);
    }
    return ans;
  }
  public decimal CalculateTotal()
  {
    decimal total = 0;
    foreach (var e in entries)
    {
      total += e.Amount;
    }
    return total;
  }

  public List<T> GetAllEntries() { return entries; }
}