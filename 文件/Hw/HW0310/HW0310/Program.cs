using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0310
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("請輸入一個數字");
            n=int.Parse( Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.Write(F(i).ToString() + ",");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        private static int F(int i)
        {
            if (i == 0 || i == 1)
                return i;
            else
                return F(i - 1) + F(i - 2);
        }
    }
}
