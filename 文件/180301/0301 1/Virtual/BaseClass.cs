using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class BaseClass
    {
        
        public virtual void Execute()
        {
            Console.WriteLine("BaseClass Execute Method");
        }
        public virtual void Begin()
        {
            Console.WriteLine("BaseClass Begin  Method");
            
        }
    }
}
