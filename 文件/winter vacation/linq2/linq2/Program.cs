using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            var result1 = list.Where((x) => x.Age > 40).ToList();
            var result2 = list.Where((x) => x.Age > 40).ToArray();

            var result3 = list.Where((x) => x.Age > 40).ToDictionary((x) => x.Name);

            foreach (var item in result3)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.Name + "--" + item.Value.Age);

            }
            Console.WriteLine("-----------------------");
            var result4 = list.ToDictionary((x) => x.Name, (y) => y.Age);
            foreach (var item in result4)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            
            //int total = list.Sum((x) => x.Age);
            //Console.WriteLine("年齡總和為:" + total);
            //var minAge = list.Min((x) => x.Age);
            //Console.WriteLine("最小年齡為:" + minAge);
            //var maxAge = list.Max((x) => x.Age);
            //Console.WriteLine("最大年齡為:" + maxAge);

            //int count = list.Count();
            //Console.WriteLine("list總個數為:" + count);

            //int countOfBill = list.Count((x) => x.Name=="Bill");
            //Console.WriteLine("list中的Bill數量為:" + countOfBill);
            //var average = list.Average((x) => x.Age);
            //Console.WriteLine("年齡平均值為:" + average);
            Console.ReadLine();
        }

        //private static List<MyData> GetList()
        //{
        //    return CreateList();
        //}

        static List<MyData> CreateList()
        {
            var list = new List<MyData>();
            list.Add(new MyData() { Name = "Bill", Age = 47 });
            list.Add(new MyData() { Name = "John", Age = 37 });
            list.Add(new MyData() { Name = "Tom", Age = 48 });
            list.Add(new MyData() { Name = "David", Age = 36 });
            list.Add(new MyData() { Name = "Bill", Age = 35});
            return list;
        }
    }
}
