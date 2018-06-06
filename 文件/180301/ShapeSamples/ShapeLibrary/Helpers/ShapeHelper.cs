using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Helpers
{
   public static class ShapeHelper
    {
        public static double ComputeArea(this Rectangle input)
        {
            return input.Width * input.Heigt;

        }
        public static double ComputeArea(this circle input)
        {
            return Math.PI * Math.Pow(input.Radius, 2);
        }
        public static double ComputePerinmeter(this Rectangle input)
        {
            return (input.Width * input.Heigt)*2;

        }
        public static double ComputePerimeter(this circle input)
        {
            return 2 * input.Radius*Math.PI;
        }
    }
}
