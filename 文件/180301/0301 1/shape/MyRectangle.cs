using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class MyRectangle : MyShape

    {
        public double Width { get; set; }
        public double Height { get; set; }
       

        public override double GetArea()
        {
            return Width * Height;
            //return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
