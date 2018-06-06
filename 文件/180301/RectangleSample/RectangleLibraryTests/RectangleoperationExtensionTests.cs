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
    public class RectangleoperationExtensionTests
    {
        [TestMethod()]
        public void ComputerAreaTest()
        {
            int expected = 25;
            Rectangle input = new Rectangle();
            input.Width = 5;
            input.Height = 5;
            int actual = RectangleoperationExtension.ComputeArea(input);

            Assert.AreEqual(expected, actual);
            
        }
        public void ComputeAreaTest()
        {
            int expected = 0;
            Rectangle input = new Rectangle();
            input.Width = 0;
            input.Height = 0;
            int actual = RectangleoperationExtension.ComputeArea(input);

            Assert.AreEqual(expected, actual);







        }
    }
}