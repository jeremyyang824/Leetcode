using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ136_SingleNumberTest
    {
        [TestMethod]
        public void OJ136_SingleNumberTest1()
        {
            int result = new OJ136_SingleNumber().SingleNumber(new int[] { 2, 1, 4, 5, 2, 4, 1 });
            Assert.AreEqual(5, result);
        }
    }
}
