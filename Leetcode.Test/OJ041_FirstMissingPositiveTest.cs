using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ041_FirstMissingPositiveTest
    {
        [TestMethod]
        public void OJ041_FirstMissingPositiveTest1()
        {
            int result = new OJ041_FirstMissingPositive().FirstMissingPositive(new int[] { 1, 2, 0 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void OJ041_FirstMissingPositiveTest2()
        {
            int result = new OJ041_FirstMissingPositive().FirstMissingPositive(new int[] { 3, 4, -1, 1 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void OJ041_FirstMissingPositiveTest3()
        {
            int result = new OJ041_FirstMissingPositive().FirstMissingPositive(new int[] { });
            Assert.AreEqual(1, result);
        }
    }
}
