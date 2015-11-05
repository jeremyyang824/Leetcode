using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ065_ValidNumberTest
    {
        [TestMethod]
        public void OJ065_ValidNumberTest1()
        {
            bool result = new OJ065_ValidNumber().IsNumber("-3.45");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ065_ValidNumberTest2()
        {
            bool result = new OJ065_ValidNumber().IsNumber("-3.4.5");
            Assert.AreEqual(false, result);
        }
    }
}
