using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        public int X { get;private set; }
        public Class1():this(0)
        {

          //  X = 0;
        }
        public Class1(int y)
        {
            X = y;
        }
       
        //public List<string> DoWhere(List<string> source,/*MyPredicate*/Func<string,bool> predicate)
        //{
        //    List<string> result = new List<string>();
        //    foreach (var item in source)
        //    {
        //        if (predicate.Invoke(item))
        //        {
        //            result.Add(item);
        //        }
        //    }
        //    return result;

        //}
         public class  BaseClass
{
            public int X { get;private set; }
            public BaseClass():this(0)
                {}
            public BaseClass (int y)
                {
                X= y;
                }

}
        public class Class1 : BaseClass
            {
            public int K {get; set;}
            public Class1 (int x , int y):base (y)
                {
                K=x;

            }
    }    }
}

