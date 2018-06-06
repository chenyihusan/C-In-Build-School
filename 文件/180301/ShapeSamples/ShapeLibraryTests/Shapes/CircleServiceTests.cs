using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes.Tests
{
    [TestClass()]
    public class CircleServiceTests
    {
        [TestMethod()]
        public void ComputeAreaTest()
        {
            double expected = 0;
            circle input = new circle();
            input.Radius = 0;
            CircleService operation = new CircleService();
            operation.Target = input;
            double actual = operation.ComputeArea();
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void ComputePerimeterTest()
        {
            double expected = 0;
            circle input = new circle();
            input.Radius = 0;
            CircleService operation = new CircleService();
            operation.Target = input;
            double actual = operation.ComputePerimeter();
            Assert.AreEqual(expected, actual);
        }
    }
}