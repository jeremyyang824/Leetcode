using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ085_MaximalRectangleTest
    {
        [TestMethod]
        public void OJ085_MaximalRectangleTest1()
        {
            int result = new OJ085_MaximalRectangle().MaximalRectangle(new char[,] {
                { '0', '1', '0', '1', '0', '0' },
                { '0', '1', '1', '0', '0', '1' },
                { '1', '1', '1', '0', '1', '0' },
                { '0', '0', '0', '0', '0', '1' },
            });
            Assert.AreEqual(4, result);
        }
    }
}
