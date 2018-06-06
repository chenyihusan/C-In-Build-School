using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes
{
    public class CircleService : IShapeService
    {
        public circle Target { get; set; }
        public double ComputeArea()
        {
            return Math.PI * Math.Pow(Target.Radius, 2);

        }
        public double ComputePerimeter()
        {
            return 2 * Math.PI * Target.Radius;
        }


    }
}
