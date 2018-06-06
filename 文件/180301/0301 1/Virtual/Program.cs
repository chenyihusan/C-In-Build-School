using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new Class1();//變數是富類別 執行個體柿子類別

            o1.Execute();//複寫過
            o1.Begin();//

            BaseClass o2 = new Class2();
            o2.Execute();
            o2.Begin();


            Console.ReadLine();
        }
    }
}
