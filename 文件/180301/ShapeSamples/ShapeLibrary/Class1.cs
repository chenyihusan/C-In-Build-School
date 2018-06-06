using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Heigt { get; set; }
    }
    public class circle
    {
        public double Radius { get; set;}
    }
    public interface IShapeService
    {
        double ComputeArea();
        double ComputePerimeter();
    }
    public class RectangleService : IShapeService
    {
       public Rectangle  Target {get; set;}
        public double ComputeArea()
        {
            return Target.Width * Target.Width;
        }
        public double ComputePerimeter()
        {
            return (Target.Width * Target.Heigt) * 2;
        }

     }
        
        
         
}
