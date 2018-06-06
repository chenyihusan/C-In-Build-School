using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            int x = 0;
            int y = 0;
            int t = 0;
            while (i != 0)
            {
                if (y == 3)
                {
                    x = 0;
                    y = 1;
                    i--;

                }
                else
                {
                    i--;
                    x = 1;
                    y++;
                    t++;
                }

               

            } Console.WriteLine("要買" + t + "次"); 
            

        }
    }
}
