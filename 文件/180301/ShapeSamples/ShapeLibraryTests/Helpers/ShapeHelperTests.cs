using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Helpers.Tests
{
    [TestClass()]
    public class ShapeHelperTests
    {
        [TestMethod()]
        public void ComputeAreaTest()
        {
            double expected = 20;
            Rectangle input = new Rectangle();
            input.Width = 5;
            input.Heigt = 4;
            double actual = ShapeHelper.ComputeArea(input);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void ComputeAreaTest1()
        {
            double expected = 0;
            circle input = new circle();
            input.Radius = 0;
            double actual = ShapeHelper.ComputeArea(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ComputePerinmeterTest()
        {
            double expected = 40;
            Rectangle input = new Rectangle();
            input.Width = 5;
            input.Heigt = 4;
            double actual = ShapeHelper.ComputePerinmeter(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ComputePerimeterTest()
        {
            double expected = 0;
            circle input = new circle();
            input.Radius = 0;
            double actual = ShapeHelper.ComputePerimeter(input);
            Assert.AreEqual(expected, actual);
        }

    }
}