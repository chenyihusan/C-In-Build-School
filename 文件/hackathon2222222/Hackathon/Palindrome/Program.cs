using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一串數字");
            string input = Console.ReadLine();
            StringBuilder a = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                a.Append(input[i]);
            
            }
            if (input.Equals(a.ToString()))
                Console.WriteLine("是回文");
            else
                Console.WriteLine("不是回文");
            Console.ReadLine();

        }
    }
}
