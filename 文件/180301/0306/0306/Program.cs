using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0306
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1.Execute();

           // Console.ReadLine();

            List<string> list = new List<string> { "a", "b" };
            list.Where((x)=>x=="a").First();


        }
    }
}
