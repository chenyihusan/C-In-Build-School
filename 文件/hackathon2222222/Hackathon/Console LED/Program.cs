using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_LED
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string a =  "    ";
            string b =  " |  " ;
            string c =  "  _|" ;
            string d =  " |_|" ;
            string e =  " |_ " ;
            string f =  "  _ " ;
            string g =  "   |";
            Console.WriteLine(a+f+f+f+f + f + f);
            Console.WriteLine(b+c+c+d + c + c + d);
            Console.WriteLine(b+e+c+d + e + c + d);
            Console.ReadLine();



        }
    }
}
