using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ137_SingleNumberIITest
    {
        [TestMethod]
        public void OJ137_SingleNumberIITest1()
        {
            int result = new OJ137_SingleNumberII().SingleNumber(new int[]{});
            Assert.AreEqual(0, result);
        }
    }
}
