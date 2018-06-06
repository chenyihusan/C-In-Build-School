using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0307
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass y = new TestClass();
            Console.WriteLine($"實體中x的初始值為{y.x}");
            ChangeX(y);
            Console.WriteLine($"退出Change 方法回到Main 方法後,實體中的x的質為{y.x}");
            Console.ReadLine();

        }

        private static TestClass ChangeX( TestClass y)
        {
            Console.WriteLine($"進入ChangeX 方法的時候 x的質為{y.x}");
            y.x = 10;
            Console.WriteLine($"在 ChangeX 方法重新指派後 , x 的質為{y.x}");
            y = new TestClass();
            Console.WriteLine($"在ChangeX 方法重新產生 TestClass 的實驗後, y 實體中的x質為{y.x}");



            return y;
          
        }
        public class TestClass
        {
            public int x = 0; 
        }
    }
}
