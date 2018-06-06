using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   // public delegate bool MyPredicate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();
            Display("o1", o1.X);     //建構式多載

            Class1 o2 = new Class1(99);
            Display("o2", o2.X);

            Console.ReadLine();
            //_____________________________________________________________________________________
            //    List<string> source
            //       = new List<string> { "Bill", "John", "David", "Tom", "David" };
            //    Class1 obj = new Class1();
            //    MyPredicate predicate = SearchDavid;
            //    var result = obj.DoWhere( source,(x) => { return x == "David"; });
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.ReadLine();
            //}
            //static void test(out int x)
            //{

            //}

            //_________________________________________________
            //    static void ShowText(string msg)
            //    {
            //        Console.WriteLine($"ShowText{msg}");
            //    }
            //    static void ShowMessage(string str)
            //    {
            //        Console.WriteLine($"ShowMessage{str}");
            //    }
            //    static void Main(string[] args)
            //{
            //    SomeAction action1 = new SomeAction(ShowText);
            //        action1 += ShowMessage;

            //        SomeAction action2 = ShowText;
            //        action1.Invoke("第一個");
            //        action2("第二個");

            //        Console.ReadLine();
            //_________________________________________________



            //static bool SearchDavid(string value)
            //{
            //    return (value == "David");
            //}


        }
        //----------------------------------------------------------------------
        static void Display(string name, int value)
        {
            Console.WriteLine($"{name}的X是{value}");
        }
   

    
}   }
   

