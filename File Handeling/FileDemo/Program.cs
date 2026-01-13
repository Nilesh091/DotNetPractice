
class Program
{
  public static void Main()
  {
    // FileStream fileStream = new FileStream("/Users/nrs/Dot Net Dev/File Handeling/Text.txt", FileMode.Open, FileAccess.ReadWrite);
    // StreamWriter streamWriter = new StreamWriter(fileStream);
    // Console.WriteLine("Enter your name");
    // // String str = Console.ReadLine();
    // // streamWriter.Write(str);
    // AppendinFile appendinFile = new AppendinFile();
    // appendinFile.Append();
    // FileDemo1 fileDemo1 = new FileDemo1();
    // fileDemo1.ReadTxt();

    // streamWriter.Close();
    //----------------------------------------------------------------------------
    // BinaryWriter bw = new BinaryWriter(File.Open("emp.dat", FileMode.Create));
    // bw.Write(102);
    // bw.Write("Nilesh R");
    // bw.Write(850000);
    // bw.Close();

    // BinaryReader br = new BinaryReader(File.Open("emp.dat", FileMode.Open));
    // int id = br.ReadInt32();
    // string name = br.ReadString();
    // int salary = br.ReadInt32();

    // Console.WriteLine(id + " " + name + " " + salary);
    // br.Close();


    //-==================-==================-=======================-=================
    File.Open("NF1.txt", FileMode.OpenOrCreate).Close();
    FileInfo fi = new FileInfo("NF1.txt");
    Console.WriteLine("FileName Is: " + fi.Length);
    Console.WriteLine("FileCreationTime is: " + fi.CreationTime.ToLongTimeString());
    Console.WriteLine("File Last Access Time is : " + fi.LastAccessTime.ToLongDateString());
    Console.WriteLine("The Length of the File is : " + fi.Length.ToString() + " Bytes");
    Console.WriteLine("Is File Exist or Not ? : " + fi.Exists);
    Console.WriteLine("File Extension is : " + fi.Extension);


  }
}