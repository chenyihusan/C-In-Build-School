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
    public class RectangleOperationHelperTests
    {
        [TestMethod()]
        public void ComputeAreaTest()
        {
            int expected = 25;
            Rectangle input = new Rectangle();
            input.Width = 5;
            input.Height = 5;
            int actual = RectangleOperationHelper.ComputeArea(input);
               
                Assert.AreEqual(expected,actual);
        }
    }
}