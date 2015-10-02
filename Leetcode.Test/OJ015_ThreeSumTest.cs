using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ015_ThreeSumTest
    {
        [TestMethod]
        public void OJ015_ThreeSumTest1()
        {
            IList<IList<int>> result = new OJ015_ThreeSum().ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });

            Assert.AreEqual(2, result.Count);

            Assert.AreEqual(-1, result[0][0]);
            Assert.AreEqual(-1, result[0][1]);
            Assert.AreEqual(2, result[0][2]);

            Assert.AreEqual(-1, result[1][0]);
            Assert.AreEqual(0, result[1][1]);
            Assert.AreEqual(1, result[1][2]);
        }

        [TestMethod]
        public void OJ015_ThreeSumTest2()
        {
            IList<IList<int>> result = new OJ015_ThreeSum().ThreeSum(new int[] { -2, 0, 0, 2, 2 });

            Assert.AreEqual(1, result.Count);

            Assert.AreEqual(-2, result[0][0]);
            Assert.AreEqual(-0, result[0][1]);
            Assert.AreEqual(2, result[0][2]);
        }

        [TestMethod]
        public void OJ015_ThreeSumTest3()
        {
            IList<IList<int>> result = new OJ015_ThreeSum().ThreeSum(new int[] { 0, 0, 0, });
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void OJ015_ThreeSumTest4()
        {
            IList<IList<int>> result = new OJ015_ThreeSum().ThreeSum(new int[] { -2, 0, 1, 1, 2 });
            Assert.AreEqual(2, result.Count);

            Assert.AreEqual(-2, result[0][0]);
            Assert.AreEqual(0, result[0][1]);
            Assert.AreEqual(2, result[0][2]);

            Assert.AreEqual(-2, result[1][0]);
            Assert.AreEqual(1, result[1][1]);
            Assert.AreEqual(1, result[1][2]);
        }
    }
}
