using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WV2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("輸入一串以逗號分隔的字串");
            string input = Console.ReadLine();
            char[] Arrayinput = input.ToCharArray();
            Array.Reverse(Arrayinput);
            input = new string(Arrayinput);
           Console.WriteLine( input);



            //for (int v = 0; v < Arrayinput.Length; v++)
            //{
            //    Console.WriteLine(Arrayinput[v].ToString());
            //}
        }
    }
}
