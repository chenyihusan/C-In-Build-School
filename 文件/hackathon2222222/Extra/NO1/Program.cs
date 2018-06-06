using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO1
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num = 0, a = 0, i = 0, x = 0;
            for (x = 101; x <= 201; x++)
            {
                i = 0;
                for (a = 1; a <= x; a++)
                {
                    if (x % a == 0)
                        i++;
                }
                if (i == 2)
                    Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
