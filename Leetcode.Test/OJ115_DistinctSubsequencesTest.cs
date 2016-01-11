using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ115_DistinctSubsequencesTest
    {
        [TestMethod]
        public void OJ115_DistinctSubsequencesTest1()
        {
            int result = new OJ115_DistinctSubsequences().NumDistinct("rabbbit", "rabbit");
            Assert.AreEqual(3, result);
        }
    }
}
