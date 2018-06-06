using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                string v = i.ToString();
                v = v.Replace("3", "A");
                v = v.Replace("5", "B");
                v = v.Replace("9", "c");
                v = v.Replace("0", "D");
                Console.Write(v + ",");

            }
            
        }
    }
}
