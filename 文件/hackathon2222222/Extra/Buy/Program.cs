using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buy
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z = 0;
            //int t = 0;

            for (x = 1; x < 16; x++)
            {
                if(((900 - (59 * x)) % 29) == 0)
                {  y = (900 - 59 * x) / 29;
                    z = 100 - x - y;
                    Console.WriteLine(x + "隻公雞" + y + "隻母雞" + z + "隻小雞");
                }
            }
            Console.ReadLine();

        }
    }
}
