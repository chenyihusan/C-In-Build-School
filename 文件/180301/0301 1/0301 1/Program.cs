using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0301_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 o1 = new Class1();
            //Class1 o2 = new Class1();
            //bool result = o1.Equals(o2);
            //Console.WriteLine("o1.Equals(o2 is " + result);

            //Console.ReadLine();

            //int i = 5;
            //string r1 = string.Format("1{0}124", i);
            //Console.WriteLine(r1);
            //string rr = $"11743";
            //Console.WriteLine(rr);
            //object[] array = new object[] { 11, 12, 13, 14 };
            //string re = string.Format("{1},{0}");

            //string s1 = "ABC";
            //string s2 = "ABC";

            //int? i = 10;//Nullable <int> i = 10;
            //if (i.HasValue)
            //{ Console.WriteLine(i); }

            //i = null;
            //if (!i.HasValue)//等於(i == null)
            //{ Console.WriteLine(i.GetValueOrDefault()); }

            //if (i == null)
            //{ Console.WriteLine("i is null");}
            //Console.ReadLine();
            //----------------------------------------------------------------------------------------------
            //var myweek = Class2.MyWeekDays.Thu;


            ////Console.WriteLine($"Today is Monday");

            //if (myweek == Class2.MyWeekDays.Mon)
            //{
            //    Console.WriteLine("Today is Monday");
            //}
            //else
            //{
            //    Console.WriteLine("Today is not Monday");
            //}

            //int i = (int)myweek;
            //Console.WriteLine($"The value of {myweek} is {i}");
            //Console.ReadLine();
            //----------------------------------------------------------------------------------------------



            Auth a = Auth.Read | Auth.Write;//位元運算

            if ((a & Auth.Read) == Auth.Read) // 
            {

            }
        }
        //疊加
        [Flags]
        public enum Auth
        {
            None = 0,
            Read = 1,
            Write = 2,
            Create = 4,
            Delete = 8
           

        }
    }
}
