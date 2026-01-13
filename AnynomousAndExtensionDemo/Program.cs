using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousExtensionDemo
{
    public delegate void Print(int val, string str);
    public delegate void Print1(int val);

    class Program
    {
        public static void PrintHelperMethod(Print1 printDel, int val)
        {
            val += 10;
            printDel(val);
        }
        public static void Main(string[] args)
        {
            //PrintHelperMethod(30, 20);
            //2
            //Passing Anonymous with 2 parameter
            PrintHelperMethod(delegate (int val)
            {
                Console.WriteLine("Anonymous method: {0}",val);
            },100);
            //1
            Print print = delegate (int val, string str)
            {
                Console.WriteLine($"Hello World {val} {str}");
            };

            print(100, "Welcome");

            var ManagerInfo = new //Anonymous Type
            {
                id = 1001,
                Name = "Rajesh Patel"
            };
            Console.WriteLine($"Manager id is {ManagerInfo.id}");
            Console.WriteLine($"Manager name is {ManagerInfo.Name}");
            //ManagerInfo.id = 1002; //error
            //ManagerInfo.Name = "Rakesh Kumar"; //error

            //MyMethod(ManagerInfo);
        }
        public static void MyMethod(dynamic dy)
        {
            Console.WriteLine(dy);
            Console.WriteLine(dy);
        }
    }
}