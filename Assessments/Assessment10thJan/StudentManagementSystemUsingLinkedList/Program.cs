using System.Data.Common;

class Program
{
  public static void Main()
  {
    LinkedList<string> ll = new LinkedList<string>();
    while (true)
    {
      Console.WriteLine("1. Add Student \n 2. Display Students \n 3. Update Student \n 4. Delete Student by Name \n 5. Clear List \n 6. Exit");
      int n = Convert.ToInt32(Console.ReadLine());
      if (n == 1)
      {
        string name = Console.ReadLine();
        ll.AddLast(name);
        Console.WriteLine("Studet is added successfully. ");
      }
      else if (n == 2)
      {
        Console.WriteLine("List of all the Students Currently.");
        foreach (var v in ll)
        {
          Console.WriteLine(v);
        }
      }
      else if (n == 3)
      {
        Console.WriteLine("Enter a name to be updated.");
        string s = Console.ReadLine();
        Console.WriteLine("Enter the updated name.");
        string newS = Console.ReadLine();
        if (!ll.Contains(s))
        {
          Console.WriteLine("The List doesnot contain this name previously.");
        }
        else
        {
          LinkedListNode<string> node = ll.First;
          while (node != null)
          {
            if (node.Value == s)
            {
              node.Value = newS;
              Console.WriteLine("Node data Updated Successfully.");
              break;
            }
            node = node.Next;
          }

        }
      }
      else if (n == 4)
      {
        string s = Console.ReadLine();
        if (!ll.Contains(s))
        {
          Console.WriteLine("Not found in the list.");
        }
        else
        {
          LinkedListNode<string> node = ll.First;
          while (node != null)
          {
            if (node.Value == s)
            {
              ll.Remove(node);
              Console.WriteLine("Node removed successfully.");
              break;
            }
            node = node.Next;
          }
        }
      }
      else if (n == 5)
      {
        ll.Clear();
      }
      else if (n == 6)
      {
        break;
      }
    }
  }
}