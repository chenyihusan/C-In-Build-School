
using RectangleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int height = 0;
            Console.WriteLine("請輸入長方形的寬");
            Int32.TryParse(Console.ReadLine(), out width);
            Console.WriteLine("請輸入長方形的高");
            Int32.TryParse(Console.ReadLine(), out height);
            Rectangle rect = new Rectangle() { Width = width, Height = height };
            RectangleOperation operation = new RectangleOperation();
            operation.Target = rect;
            int area = operation.ComputeArea();
            Console.WriteLine($"長方形的面積為{area}");

            Console.ReadLine();
        }
    }
}
