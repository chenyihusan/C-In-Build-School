using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wv4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("輸入一串以逗號分隔的整數字串:");
            string [] input = Console.ReadLine().Split(',');
            string input = input.TrimEnd;
            var grouping = from n in input
                         group n by int.Parse(n) % 2 == 0;
            foreach (var item in grouping)
            {
                if (item.Key)
                {
                    Console.Write("偶數:");
                }
                else
                {
                    Console.Write("奇數:");
                }
                foreach (var n in item)
                {
                    
                    Console.Write(n+',');
                  
                }
                Console.WriteLine();



            }
          
            
                    

        }

        
    }
}
