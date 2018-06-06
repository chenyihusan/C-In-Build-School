using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {

        static void Main(string[] args)
        {
            var list = CreateList();
            bool isAllBill=list.All((x)) =>x.Name=="Bill");
        }
        static List<MyData> CreateList()
        {
            List<MyData> list = new List<MyData>();
            list.Add(new MyData(){ Name = "Bill",Age = 47});
            list.Add(new MyData(){ Name = "John",Age = 37});
            list.Add(new MyData(){ Name = "Tom",Age = 48});
            list.Add(new MyData(){ Name = "David",Age = 36});
            list.Add(new MyData(){ Name = "Bill",Age = 35});
            list.Add(new MyData(){ Name = "Tom",Age = 48});
            return list;
            
        }
        

     





    }
}
