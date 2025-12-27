using System;

class SaleTransaction
{
  public string InvoiceNo { get; set; }
  public string CustomerName { get; set; }
  public string ItemName { get; set; }
  public int Quantity { get; set; }
  public decimal PurchaseAmount { get; set; }
  public decimal SellingAmount { get; set; }
  public string ProfitOrLossStatus { get; set; }
  public decimal ProfitOrLossAmount { get; set; }
  public decimal ProfitMarginPercent { get; set; }
}

class Program
{
  static SaleTransaction LastTransaction;
  static bool HasLastTransaction = false;

  static void Main()
  {
    bool flag = true;
    while (flag)
    {
      Console.WriteLine("================== QuickMart Traders ==================");
      Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
      Console.WriteLine("2. View Last Transaction");
      Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
      Console.WriteLine("4. Exit");
      Console.Write("Enter your option: ");

      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          CreateTransaction();
          break;
        case "2":
          ViewLastTransaction();
          break;
        case "3":
          Recalculate();
          break;
        case "4":
          Console.WriteLine("Thank you. Application closed normally.");
          flag = false;
          break;
        default:
          Console.WriteLine("Invalid option. Please try again.");
          break;
      }
    }
  }
  static void CreateTransaction()
  {
    SaleTransaction t = new SaleTransaction();

    Console.Write("Enter Invoice No: ");
    t.InvoiceNo = Console.ReadLine();
    if (t.InvoiceNo == "")
    {
      Console.WriteLine("Invoice No cannot be empty.");
      return;
    }

    Console.Write("Enter Customer Name: ");
    t.CustomerName = Console.ReadLine();

    Console.Write("Enter Item Name: ");
    t.ItemName = Console.ReadLine();

    Console.Write("Enter Quantity: ");
    int qty;
    qty = Convert.ToInt32(Console.ReadLine());
    if (qty <= 0)
    {
      Console.WriteLine("Quantity must be greater than zero.");
      return;
    }
    t.Quantity = qty;

    Console.Write("Enter Purchase Amount (total): ");
    decimal pAmt;
    pAmt = Convert.ToDecimal(Console.ReadLine());
    if (pAmt <= 0)
    {
      Console.WriteLine("Purchase Amount must be greater than zero.");
      return;
    }
    else
    {
      t.PurchaseAmount = pAmt;
    }

    Console.Write("Enter Selling Amount (total): ");
    decimal sAmt;
    sAmt = Convert.ToDecimal(Console.ReadLine());
    if (sAmt < 0)
    {
      Console.WriteLine("Selling Amount must be zero or greater.");
      return;
    }
    t.SellingAmount = sAmt;

    Calculate(t);

    LastTransaction = t;
    HasLastTransaction = true;

    Console.WriteLine("\nTransaction saved successfully.");
    PrintCalculation(t);
  }
  static void ViewLastTransaction()
  {
    if (!HasLastTransaction)
    {
      Console.WriteLine("No transaction available. Please create a new transaction first.");
      return;
    }

    var t = LastTransaction;
    Console.WriteLine("\n-------------- Last Transaction --------------");
    Console.WriteLine($"InvoiceNo: {t.InvoiceNo}");
    Console.WriteLine($"Customer: {t.CustomerName}");
    Console.WriteLine($"Item: {t.ItemName}");
    Console.WriteLine($"Quantity: {t.Quantity}");
    Console.WriteLine($"Purchase Amount: {t.PurchaseAmount:F2}");
    Console.WriteLine($"Selling Amount: {t.SellingAmount:F2}");
    Console.WriteLine($"Status: {t.ProfitOrLossStatus}");
    Console.WriteLine($"Profit/Loss Amount: {t.ProfitOrLossAmount:F2}");
    Console.WriteLine($"Profit Margin (%): {t.ProfitMarginPercent:F2}");
    Console.WriteLine("--------------------------------------------");
  }
  static void Recalculate()
  {
    if (!HasLastTransaction)
    {
      Console.WriteLine("No transaction available. Please create a new transaction first.");
      return;
    }

    Calculate(LastTransaction);
    PrintCalculation(LastTransaction);
  }
  static void Calculate(SaleTransaction t)
  {
    if (t.SellingAmount > t.PurchaseAmount)
    {
      t.ProfitOrLossStatus = "PROFIT";
      t.ProfitOrLossAmount = t.SellingAmount - t.PurchaseAmount;
    }
    else if (t.SellingAmount < t.PurchaseAmount)
    {
      t.ProfitOrLossStatus = "LOSS";
      t.ProfitOrLossAmount = t.PurchaseAmount - t.SellingAmount;
    }
    else
    {
      t.ProfitOrLossStatus = "BREAK-EVEN";
      t.ProfitOrLossAmount = 0;
    }

    t.ProfitMarginPercent = (t.ProfitOrLossAmount / t.PurchaseAmount) * 100;
  }

  static void PrintCalculation(SaleTransaction t)
  {
    Console.WriteLine($"Status: {t.ProfitOrLossStatus}");
    Console.WriteLine($"Profit/Loss Amount: {t.ProfitOrLossAmount:F2}");
    Console.WriteLine($"Profit Margin (%): {t.ProfitMarginPercent:F2}");
    Console.WriteLine("------------------------------------------------------");
  }
}