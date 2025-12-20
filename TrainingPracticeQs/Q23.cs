class Q23
{
  public void printQ23()
  {
    // Finding Whether the number is a Armstrong Number or Not
    Console.WriteLine("Enter a number to check whether the number is Armstrong or not ?? :");
    int num = Convert.ToInt32(Console.ReadLine());
    int numDegit = (num == 0) ? 1 : (int)Math.Log10(num) + 1;//through logarithmic mathmetical function we can calculate the number of degits in a number
    // Method 2: converting the number into string
    String numStr = num.ToString();
    int numDegit2 = numStr.Length;
    bool ans = isArmstrong(num, numDegit);
    if (ans) Console.WriteLine($"Yes the Number {num} is an Armstrong Number");
    else Console.WriteLine($"No the Number {num} is not an Armstrong Number");

  }
  public bool isArmstrong(int num, int numDegit)
  {
    int tempNum = num;
    int sum = 0;
    while (num > 0)
    {
      sum += (int)Math.Pow(num % 10, numDegit);
      num /= 10;
    }
    if (sum == tempNum) return true;
    return false;
  }
}