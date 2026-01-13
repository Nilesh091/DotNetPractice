class FileDemo1
{
  public void ReadTxt()
  {
    FileStream file = new FileStream("/Users/nrs/Dot Net Dev/File Handeling/Text.txt", FileMode.Open, FileAccess.Read);
    StreamReader reader = new StreamReader(file);
    reader.BaseStream.Seek(0, SeekOrigin.Begin);
    Console.WriteLine(reader.ReadToEnd());

    string line = reader.ReadLine();
    while (line != null)
    {
      Console.WriteLine(line);
      line = reader.ReadLine();
    }
    reader.Close();

  }
}