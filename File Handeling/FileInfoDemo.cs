using System.IO;
class FileInfoDemo
{
  public void FileInfoDemo()
  {
    //Implementing the file info class
    // create a file i. this drectory /Users/nrs/Dot Net Dev/File Handeling
    //create a file in c# using FileInfo Class
    string path = "/Users/nrs/Dot Net Dev/File Handeling/test.txt";
    FileInfo fi = new FileInfo(path);
    if (!fi.Exists)
    {
      Console.WriteLine("The file does not exist");
      return;
    }
    else
    {
      Console.WriteLine("The file exists");
    }

    // Manipulate file through fileInfo class
    // mentioin all the methods of fileinfo class
    // get length of the file
    Console.WriteLine("Length of the file is " + fi.Length);
    



  }
}