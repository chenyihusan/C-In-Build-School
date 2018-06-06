using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRectangle2
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int ComputeArea()
        {
            return Width * Height;
        }
    }
}
