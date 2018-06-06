using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wv7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入四位數的阿拉伯數字:");
            string input = Console.ReadLine();
           
            input = input.Replace("1", "一");
            input = input.Replace("2", "二");
            input = input.Replace("3", "三");
            input = input.Replace("4", "四");
            input = input.Replace("5", "五");
            input = input.Replace("6", "六");
            input = input.Replace("7", "七");
            input = input.Replace("8", "八");
            input = input.Replace("9", "九");
            input = input.Replace("0", "零");
            Console.WriteLine("輸出結果為:" + input);
            Console.ReadLine();
        }
        
    }
}
