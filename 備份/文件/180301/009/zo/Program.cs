using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"鼠","兔","龍","蛇","狗","豬","馬","羊","猴","雞","牛","虎" };
           
            foreach (var item in list.OrderBy((x) => x, new zo()))
            {
                Console.WriteLine(item);
            }
            
        }
        public class zo : IComparer<string>
        {
            private static List<string> list2 = new List<string>() { "鼠", "牛", "虎", "兔", "龍", "蛇", "馬", "羊", "猴", "雞", "狗", "豬" };
            public int Compare(string x, string y)
            {
                
               return( list2.IndexOf(x)-list2.IndexOf(y));
               
            }
        }
    }
}
