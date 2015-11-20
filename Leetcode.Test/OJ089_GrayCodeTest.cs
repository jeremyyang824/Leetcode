using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ089_GrayCodeTest
    {
        [TestMethod]
        public void OJ089_GrayCodeTest1()
        {
            IList<int> result = new OJ089_GrayCode().GrayCode(2);

            Assert.AreEqual(0, result[0]);  //00
            Assert.AreEqual(1, result[1]);  //01
            Assert.AreEqual(3, result[2]);  //11
            Assert.AreEqual(2, result[3]);  //10
        }

        [TestMethod]
        public void OJ089_GrayCodeTest2()
        {
            IList<int> result = new OJ089_GrayCode().GrayCode(3);

            Assert.AreEqual(0, result[0]);  //000
            Assert.AreEqual(1, result[1]);  //001
            Assert.AreEqual(3, result[2]);  //011
            Assert.AreEqual(2, result[3]);  //010
            Assert.AreEqual(6, result[4]);  //110
            Assert.AreEqual(7, result[5]);  //111
            Assert.AreEqual(5, result[6]);  //101
            Assert.AreEqual(4, result[7]);  //100
        }
    }
}
