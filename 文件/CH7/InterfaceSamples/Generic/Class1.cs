using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
   public static  class Class1
    {
        public static IEnumerable<T> DoWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;

        }
    }
}
