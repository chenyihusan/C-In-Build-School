using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Services;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Services.Tests
{
    [TestClass()]
    public class CircleServiceTests
    {
        [TestMethod()]
        public void Given_Circle_Radius_5_When_ComputeArea_Then_25XPI()
        {
            double expected = 25 * Math.PI;
            Circle input = new Circle();
            input.Radius = 5;
            CircleService  service = new CircleService();
            service.Target = input;
            double actual = service.ComputeArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Circle_Radius_5_When_ComputePerimeter_Then_10XPI()
        {
            double expected = 10 * Math.PI;
            Circle input = new Circle();
            input.Radius = 5;
            CircleService service = new CircleService();
            service.Target = input;
            double actual = service.ComputePerimeter();
            Assert.AreEqual(expected, actual);
        }
    }
}