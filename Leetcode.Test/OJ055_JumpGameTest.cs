using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ055_JumpGameTest
    {
        [TestMethod]
        public void OJ055_JumpGameTest1()
        {
            bool result = new OJ055_JumpGame().CanJump(new int[] { 2, 3, 1, 1, 4 });
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ055_JumpGameTest2()
        {
            bool result = new OJ055_JumpGame().CanJump(new int[] { 3, 2, 1, 0, 4 });
            Assert.AreEqual(false, result);
        }
    }
}
