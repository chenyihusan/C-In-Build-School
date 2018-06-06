using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Services
{
    public interface IShapeService
    {
        double ComputeArea();
        double ComputePerimeter();
    }

    public class RectangleService : IShapeService
    {
        public Rectangle Target { get; set; }
        public double ComputeArea()
        {
            return Target.Width * Target.Height;
        }

        public double ComputePerimeter()
        {
            return (Target.Width + Target.Height) * 2;
        }
    }

    public class CircleService : IShapeService
    {
        public Circle Target { get; set; }
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
