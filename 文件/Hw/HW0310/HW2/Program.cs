using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("有幾隻猴子?");
            int Total=int.Parse(Console.ReadLine());
            Console.WriteLine("幾個循環殺掉一隻猴子?");
            int Kill = int.Parse(Console.ReadLine());
            int i;
            int king = 0; 
            for (i=1;i<=Total;i++)
            {
                king = (king + Kill) % i;

            }
            king++;
            Console.WriteLine("猴子國王是編號第" + king + "隻猴子");
            Console.ReadLine();
            
        }
    }
}
