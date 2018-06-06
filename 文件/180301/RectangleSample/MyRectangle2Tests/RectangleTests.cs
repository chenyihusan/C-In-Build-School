using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyRectangle2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRectangle2.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void ComputeAreaTest()
        {
            int expected = 25;
            Rectangle input = new Rectangle();
            input.Width = 5;
            input.Height = 5;
            int actual = input.ComputeArea();

            Assert.AreEqual(expected, actual);

            /*  int expected = 0;
            Rectangle input = new Rectangle();
            input.Width = 0;
            input.Height = 0;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputeArea();
            Assert.AreEqual(expected, actual);    */
        }
    }
}