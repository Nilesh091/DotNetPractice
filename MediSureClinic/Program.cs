

public class PatientBill
{
  public string BillId { get; set; }
  public string PatientName { get; set; }
  public bool HasInsurance { get; set; }
  public decimal ConsultationFee { get; set; }
  public decimal LabChages { get; set; }
  public decimal MedicineCharges { get; set; }
  public decimal GrossAmount { get; set; }
  public decimal DiscountAmount { get; set; }
  public decimal FinalPayable { get; set; }


}

class Program
{
  static PatientBill lastBill;
  static bool HasLastBill = false;
  static void Main(string[] args)
  {
    Console.WriteLine("================== MediSure Clinic Billing ==================");
    bool flag = true;
    while (flag)
    {
      Console.WriteLine("\n\nWelcome to MediSure Clinic Billing System");
      Console.WriteLine("1. Create New Bill");
      Console.WriteLine("2. View Last Bill");
      Console.WriteLine("3. Clear Last Bill");
      Console.WriteLine("4. Exit");
      int choice = Convert.ToInt32(Console.ReadLine());
      switch (choice)
      {
        case 1:
          CreateBill();
          break;
        case 2:
          if (!HasLastBill)
          {
            Console.WriteLine("No bills created yet.");
          }
          else
          {
            Console.WriteLine("----------- Last Bill -----------");
            DisplayBill(lastBill);
            Console.WriteLine("------------------------------------------------------------");
          }
          break;
        case 3:
          ClearLastBill();
          break;
        case 4:
          Console.WriteLine("Thank you. Application closed normally.");
          flag = false;
          break;
        default:
          Console.WriteLine("Invalid Choice");
          break;
      }
    }

  }
  public static void CreateBill()
  {
    PatientBill bill = new PatientBill();
    Console.WriteLine("Enter Bill Id:");
    string bid = Console.ReadLine();
    if (bid == "")
    {
      Console.WriteLine("Please enter a valid Bill ID");
    }
    else
    {
      bill.BillId = bid;
    }
    Console.WriteLine("Enter Patient Name:");
    string pname = Console.ReadLine();
    if (pname == "")
    {
      Console.WriteLine("Please enter a valid patient name");
    }
    else
    {
      bill.PatientName = pname;
    }
    Console.WriteLine("Does the patient have insurance?(y/n)");
    string hasinsurance = Console.ReadLine().ToLower();
    if (hasinsurance == "n" || hasinsurance == "no")
    {
      bill.HasInsurance = false;
    }
    else if (hasinsurance == "y" || hasinsurance == "yes")
    {
      bill.HasInsurance = true;
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
      return;
    }
    Console.WriteLine("Enter consultation fee:");
    bill.ConsultationFee = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Enter lab charges:");
    bill.LabChages = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Enter medicine charges:");
    bill.MedicineCharges = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Bill Created Successfully!");
    ComputeBillingAmounts(bill);

  }
  public static void ComputeBillingAmounts(PatientBill bill)
  {
    bill.GrossAmount = bill.ConsultationFee + bill.LabChages + bill.MedicineCharges;
    if (bill.HasInsurance)
    {
      bill.DiscountAmount = bill.GrossAmount * 0.1m;
    }
    else
    {
      bill.DiscountAmount = 0;
    }
    bill.FinalPayable = bill.GrossAmount - bill.DiscountAmount;
    DisplayBill(bill);
    lastBill = bill;
    HasLastBill = true;
  }
  public static void DisplayBill(PatientBill bill)
  {
    Console.WriteLine($"Patient Name: {bill.PatientName}");
    Console.WriteLine($"Consultation Fee: ${bill.ConsultationFee:F2}");
    Console.WriteLine($"Lab Charges: ${bill.LabChages:F2}");
    Console.WriteLine($"Medicine Charges: ${bill.MedicineCharges:F2}");
    Console.WriteLine($"Gross Amount: ${bill.GrossAmount:F2}");
    Console.WriteLine($"Discount Amount: ${bill.DiscountAmount:F2}");
    Console.WriteLine($"Final Payable Amount: ${bill.FinalPayable:F2}");
    Console.WriteLine("-------------------------------------------------");
  }
  public static void ClearLastBill()
  {
    lastBill = null;
    HasLastBill = false;
    Console.WriteLine("Last bill cleared successfully.");
  }
}