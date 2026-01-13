class AppendinFile
{
  public void Append()
  {
    FileStream fs = new FileStream("/Users/nrs/Dot Net Dev/File Handeling/Text.txt", FileMode.Append, FileAccess.Write);

    StreamWriter sw = new StreamWriter(fs);
    sw.WriteLine("Hello World");
    sw.WriteLine("Hello World 1");
    sw.WriteLine("Hello World 2");
    sw.WriteLine("Hello World 3");
    sw.Close();
  }
}