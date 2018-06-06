using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Class2:Class1
    {
        public override sealed void Execute()
        {
            Console.WriteLine("Class2 Execute Method");
        }
        public override void Begin()
        {
            Console.WriteLine("Class2 Execute Method");
        }
    }
    class class3 : Class2
    {
        public override void Execute()

        {
            Console.WriteLine("Class  ")
        }
    }
}
