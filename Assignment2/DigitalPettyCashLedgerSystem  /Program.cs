class Program
{
  public static void Main()
  {
    var IncomeLedger = new Ledger<IncomeTransaction>();
    var ExpenseLedger = new Ledger<ExpenseTransaction>();
    IncomeLedger.AddEntry(new IncomeTransaction(1, new DateTime(2023, 5, 4), 10, "Salary", "Bank"));
    IncomeLedger.AddEntry(new IncomeTransaction(2, new DateTime(2023, 6, 7), 8.99M, "Bonus", "Paypal"));
    ExpenseLedger.AddEntry(new ExpenseTransaction(1, new DateTime(2023, 5, 4), 10, "Groceries", "Food"));
    ExpenseLedger.AddEntry(new ExpenseTransaction(2, new DateTime(2023, 6, 7), 8.99M, "Rent", "Housing"));

    decimal totalIncome = IncomeLedger.CalculateTotal();
    Console.WriteLine($"Total income: {totalIncome}");
    decimal totalExpenses = ExpenseLedger.CalculateTotal();
    Console.WriteLine($"Total expenses: {totalExpenses}");
    decimal netBalance = totalIncome - totalExpenses;
    Console.WriteLine($"Net balance: {netBalance}");


    // Polymorphic Reporting
    List<Transaction> allTransactions = new List<Transaction>();
    foreach (var transaction in IncomeLedger.GetAllEntries())
    {
      allTransactions.Add(transaction);
    }
    foreach (var transaction in ExpenseLedger.GetAllEntries())
    {
      allTransactions.Add(transaction);
    }


    Console.WriteLine(" Transaction Summeries . ");
    foreach (var transaction in allTransactions)
    {
      Console.WriteLine(transaction.GetSummery());
    }


    // Filtering by Date
    Console.WriteLine("\nFiltered Transactions:\n");
    DateTime startDate = new DateTime(2023, 5, 1);
    DateTime endDate = new DateTime(2023, 6, 30);
    List<Transaction> filteredTransactions = new List<Transaction>();
    foreach (var transaction in allTransactions)
    {
      if (transaction.Date >= startDate && transaction.Date <= endDate)
      {
        filteredTransactions.Add(transaction);
      }
    }
    foreach (var transaction in filteredTransactions)
    {
      Console.WriteLine($"{transaction.Id}: {transaction.Description}, ${transaction.Amount}");
    }

  }

}