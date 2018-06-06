using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("數字為:");
            for (x = 1; x <= 100; x++)
            {
                if (x % 3 != 0 && x % 5 != 0)
                    Console.WriteLine(x);

            }

            Console.ReadLine();
        }
    }
}
