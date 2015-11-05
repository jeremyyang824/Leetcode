using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ066_PlusOneTest
    {
        [TestMethod]
        public void OJ066_PlusOneTest1()
        {
            int[] result = new OJ066_PlusOne().PlusOne(new int[] { 3, 8, 2 });
            ArrayAssert.AreEqual(new int[] { 3, 8, 3 }, result);
        }

        [TestMethod]
        public void OJ066_PlusOneTest2()
        {
            int[] result = new OJ066_PlusOne().PlusOne(new int[] { 9, 9, 9 });
            ArrayAssert.AreEqual(new int[] { 1, 0, 0, 0 }, result);
        }
    }
}
