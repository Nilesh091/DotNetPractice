class StringPractice
{
  //program to read a string and display it on the screen
  public static void readAndDisplayString()
  {
    string str = Console.ReadLine();
    Console.WriteLine(str);
  }
  //program to read 10 strings and display them on the screen
  public static void readTenStrings()
  {
    for (int i = 0; i < 10; i++)
      Console.WriteLine(Console.ReadLine());
  }
  //program to accept 2x2 matrices and display in matrix
  public static void readTwoByTwoMatrix()
  {
    int[,] mat = new int[2, 2];
    for (int i = 0; i < mat.GetLength(0); i++)
      for (int j = 0; j < mat.GetLength(1); j++)
        mat[i, j] = Convert.ToInt32(Console.ReadLine());
    foreach (var item in mat)
      Console.Write(item + " ");
  }
  //program to add 2 matrices
  public static void addMatrices()
  {
    int[,] matA = new int[2, 2];
    int[,] matB = new int[2, 2];
    int[,] sumOfMatrices = new int[2, 2];
    for (int i = 0; i < matA.GetLength(0); i++)
      for (int j = 0; j < matA.GetLength(1); j++)
        matA[i, j] = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matB.GetLength(0); i++)
      for (int j = 0; j < matB.GetLength(1); j++)
        matB[i, j] = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < sumOfMatrices.GetLength(0); i++)
      for (int j = 0; j < sumOfMatrices.GetLength(1); j++)
        sumOfMatrices[i, j] += matA[i, j] + matB[i, j];
    for (int i = 0; i < sumOfMatrices.GetLength(0); i++)
    {
      for (int j = 0; j < sumOfMatrices.GetLength(1); j++)
      {
        Console.Write(sumOfMatrices[i, j] + " ");
      }
      Console.WriteLine();
    }
  }
  //program to find the largest and smallest element in the array
  public static void findLargestSmallestElement()
  {
    int[] arr = new int[5];
    for (int i = 0; i < arr.Length; i++)
      arr[i] = Convert.ToInt32(Console.ReadLine());
    Array.Sort(arr);
    Console.WriteLine("The largest number is: " + arr[arr.Length - 1]);
    Console.WriteLine("The smallest number is: " + arr[0]);
  }
  //matrix multiplication 2 by 2
  public static void multiplyMatrices()
  {
    int[,] matA = new int[2, 2];
    int[,] matB = new int[2, 2];
    int[,] productOfMatrices = new int[matA.GetLength(0), matB.GetLength(1)];
    for (int i = 0; i < matA.GetLength(0); i++)
      for (int j = 0; j < matA.GetLength(1); j++)
        matA[i, j] = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matB.GetLength(0); i++)
      for (int j = 0; j < matB.GetLength(1); j++)
        matB[i, j] = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < productOfMatrices.GetLength(0); i++)
      for (int j = 0; j < productOfMatrices.GetLength(1); j++)
        for (int k = 0; k < productOfMatrices.GetLength(1); k++)
          productOfMatrices[i, j] += matA[i, k] * matB[k, j];
    for (int i = 0; i < productOfMatrices.GetLength(0); i++)
    {
      for (int j = 0; j < productOfMatrices.GetLength(1); j++)
      {
        Console.Write(productOfMatrices[i, j] + " ");
      }
      Console.WriteLine();
    }
  }
  //Transpose of a matrix
  public static void matrixTranspose()
  {
    int[,] mat = new int[3, 3];
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        mat[i, j] = Convert.ToInt32(Console.ReadLine());
      }
    }
    Console.WriteLine("Before Transpose:");
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        Console.Write(mat[i, j] + " ");
      }
      Console.WriteLine();
    }

    //int[,] transPoseMat = new int[3, 3];
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        if (i != j)
        {
          int temp = mat[i, j];
          mat[i, j] = mat[j, i];
          mat[j, i] = temp;
        }
      }
    }
    Console.WriteLine("After Transpise:");


    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        Console.Write(mat[i, j] + " ");
      }
      Console.WriteLine();
    }

  }
  //program to find whether the given matrix is diagonal or not
  public static void checkDiagonalMatrix()
  {
    int[,] mat = new int[4, 4];
    for (int i = 0; i < mat.GetLength(0); i++)
      for (int j = 0; j < mat.GetLength(1); j++)
        mat[i, j] = Convert.ToInt32(Console.ReadLine());
    bool flag = true;
    for (int i = 0; i < mat.GetLength(0); i++)
      for (int j = 0; j < mat.GetLength(1); j++)
        if ((i == j && mat[i, j] == 0) || (i != j && mat[i, j] != 0))
          flag = false;
    if (flag)
      Console.WriteLine("It's a Diagonal Matrix");
    else
      Console.WriteLine("Not a Diagonal Matrix");
  }
  // Reverse string
  public static void reverseString()
  {
    string str = Console.ReadLine();
    Console.WriteLine(new string(str.Reverse().ToArray()));
    //or
    // string reversedStr = "";
    // for (int i = str.Length - 1; i >= 0; i--)
    //   reversedStr += str[i];
    // Console.WriteLine(reversedStr);
    //or
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    string reversedString = new string(arr);
    Console.WriteLine(reversedString);

  }
  //program to convert from lowerletter to upperletter and vise versa
  public static void ChangeCase()
  {
    string str = Console.ReadLine();
    char[] arr = str.ToCharArray();
    for (int i = 0; i < str.Length; i++)
    {
      if (arr[i] >= 'a' && arr[i] <= 'z')
      {
        arr[i] = (char)(arr[i] - 32);
      }
      else if (arr[i] >= 'A' && arr[i] <= 'Z')
      {
        arr[i] = (char)(arr[i] + 32);
      }
    }
    Console.WriteLine("Altered String:" + new string(arr));
  }
  public static void ChangeCase2()
  {
    string str = Console.ReadLine();
    char[] arr = str.ToCharArray();
    string ans = "";
    foreach (char c in str)
    {
      if (char.IsLower(c))
      {
        ans += char.ToUpper(c);
      }
      else if (char.IsUpper(c))
      {
        ans += char.ToLower(c);
      }
      else
      {
        ans += c;
      }
    }
    Console.WriteLine("Altered String:" + ans);
  }
  // program to compare 2 strings  using standard library functions
  public static void CompareStrings()
  {
    string s1 = Console.ReadLine();
    string s2 = Console.ReadLine();
    if (string.Compare(s1, s2) > 0)
      Console.WriteLine("S1 is greater than S2");
    else if (string.Compare(s1, s2) < 0)
      Console.WriteLine("S1 is less than S2");
    else
      Console.WriteLine("Both are equal");
  }
  // program to concatenate 2 strings  using standard library functions
  public static void ConcatenateStrings()
  {
    string s1 = Console.ReadLine();
    string s2 = Console.ReadLine();
    Console.WriteLine(string.Concat(s1, s2));
  }
  // program to compare 2 strings without using standard library functions
  public static void CompareStrings2()
  {
    string s1 = Console.ReadLine();
    string s2 = Console.ReadLine();
    bool flag = true;
    if (s1.Length != s2.Length)
      flag = false;
    else
      for (int i = 0; i < s1.Length; i++)
        if (s1[i] != s2[i])
        {
          flag = false;
          break;
        }
    if (flag)
      Console.WriteLine("Both are equal");
    else
      Console.WriteLine("Both are unequal");
  }
  // program to concatenate 2 strings without using standard library functions
  public static void ConcatenateStrings2()
  {
    string s1 = Console.ReadLine();
    string s2 = Console.ReadLine();
    string concatString = "";
    for (int i = 0; i < s1.Length; i++)
      concatString += s1[i];
    for (int i = 0; i < s2.Length; i++)
      concatString += s2[i];
    Console.WriteLine(concatString);
  }
  // program  to search a string in main string
  public static void SearchString()
  {
    string s1 = Console.ReadLine();
    string s2 = Console.ReadLine();
    if (s1.Contains(s2))
      Console.WriteLine("Found");
    else
      Console.WriteLine("Not Found");
  }

}