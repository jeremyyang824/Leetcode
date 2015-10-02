using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ016_ThreeSumClosestTest
    {
        [TestMethod]
        public void OJ016_ThreeSumClosestTest1()
        {
            int result = new OJ016_ThreeSumClosest().ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1);
            Assert.AreEqual(2, result);
        }
    }
}
