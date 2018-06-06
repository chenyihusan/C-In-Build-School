using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyCircle : IShape
    {
        public double Radius { get; set; }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
