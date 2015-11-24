using System;
using System.Collections.Generic;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ093_RestoreIPAddressesTest
    {
        [TestMethod]
        public void OJ093_RestoreIPAddressesTest1()
        {
            IList<string> result = new OJ093_RestoreIPAddresses().RestoreIpAddresses("25525511135");
            Assert.AreEqual("255.255.11.135", result[0]);
            Assert.AreEqual("255.255.111.35", result[1]);
        }
    }
}
