using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleLibrary.Tests
{
    [TestClass()]
    public class RectangleOperationTests
    {
        [TestMethod()]
        public void Given_Rectangle_Width_5_Height_5_When_ComputeArea_Then_25()
        {
            int expected = 25;
            Rectangle input = new Rectangle();
            input.Width = 5;
            input.Height = 5;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputeArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Rectangle_Width_9_Height_18_When_ComputeArea_Then_162()
        {
            int expected = 162;
            Rectangle input = new Rectangle();
            input.Width = 9;
            input.Height = 18;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputeArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Rectangle_Width_0_Height_0_When_ComputeArea_Then_0()
        {
            int expected = 0;
            Rectangle input = new Rectangle();
            input.Width = 0;
            input.Height = 0;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputeArea();
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod()]
        public void Given_Rectangle_null_When_ComputeArea_Then_NullReferenceException()
        {
            Rectangle input = null;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputeArea();
        }

    }
}