using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("請輸入一個年份");
            string input = Console.ReadLine();
            value = int.Parse(input);
            if (DateTime.IsLeapYear(value))
            {
                Console.WriteLine("閏年");
            }
            else
            {
                Console.WriteLine("平年");
            }

            Console.ReadLine();
        }
    }
}
