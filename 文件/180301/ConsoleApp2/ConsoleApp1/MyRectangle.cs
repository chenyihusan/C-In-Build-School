using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyRectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double GetArea()
        {
            return Width * Height;
        }
    }
}
