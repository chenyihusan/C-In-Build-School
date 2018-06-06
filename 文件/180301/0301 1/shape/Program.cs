using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
            MyShape rect = new MyRectanglee() { Width = 10, Height = 10 };
            Console.WriteLine($"方形的面積是{ rect.GetArea()}");
            MyShape circle = new Circle(){Radius=3};
            Console.WriteLine($"圓形的面積是{ rect.GetArea()}");
            Console.ReadLine();
            MyShape shape = new MyShape();//抽象類別是無法直接用new
        }
    }
}
