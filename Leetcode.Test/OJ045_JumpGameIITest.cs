using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ045_JumpGameIITest
    {
        [TestMethod]
        public void OJ045_JumpGameIITest1()
        {
            int result = new OJ045_JumpGameII().Jump(new int[] { 2, 3, 1, 1, 4 });
            Assert.AreEqual(2, result);
        }
    }
}
