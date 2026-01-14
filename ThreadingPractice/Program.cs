using System.ComponentModel;

class Program
{
  public static void Thread1()
  {
    for (int i = 0; i < 10; i++)
    {
      Console.WriteLine(i);
      Thread.Sleep(100);
    }
  }
  public static void Thread2()
  {
    for (int i = 20; i < 30; i++)
    {
      Console.WriteLine(i);
      Thread.Sleep(100);
    }
  }
  public static void Main()
  {
    // Thread t = new Thread(Worker);
    // t.Start();
    Thread t1 = new Thread(Thread1);
    Thread t2 = new Thread(Thread2);
    t1.Priority = ThreadPriority.Highest;
    t1.Start();
    t2.Start();
    Thread.Sleep(2000);
    Console.WriteLine("The Main thread.");
  }
  public static void Worker()
  {
    Console.WriteLine("Worker Thread is running.");
    Thread.Sleep(2000);


  }
}