using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1,"david");
            d.Add(2, "john");
            d.Add(3, "bill");
            d.Add(4, "tom");
            var result =d.DoWhere<string>((x) => x=="david");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //var result = source.DoWhere<string>((x) => x == "David");
            // foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            List<int> source2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result2 = source2.DoWhere((x) => x>3);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            //Class1<int> o1 = new Class1<int>();
            //string s1 = o1.Data.GetType().ToString();
            //Display("o1.Data", s1);

            //Class1<bool> o2 = new Class1<bool>();
            //string s2 = o2.Data.GetType().ToString();
            //Display("o2.Data", s2);

            //Console.ReadLine();
        }

        //static void Display(string varName, string typeString)
        
        //{
        //    Console.WriteLine($"{varName}的型別是{typeString}");
        //}
    }
}
