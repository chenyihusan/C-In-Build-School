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
    public class RectangleServiceTests
    {
        [TestMethod()]
        public void Given_Rectangle_Width_5_Height_5_When_ComputeArea_Then_25()
        {
            double expected = 25;
            Rectangle input = new Rectangle();
            input.Width = 5;
            input.Height = 5;
            RectangleService service = new RectangleService();
            service.Target = input;
            double actual = service.ComputeArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Rectangle_Width_5_Height_5_When_ComputePerimeter_Then_20()
        {
            double expected = 20;
            Rectangle input = new Rectangle();
            input.Width = 5;
            input.Height = 5;
            RectangleService service = new RectangleService();
            service.Target = input;
            double actual = service.ComputePerimeter();
            Assert.AreEqual(expected, actual);
        }
    }
}