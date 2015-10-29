using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ052_N_QueensIITest
    {
        [TestMethod]
        public void OJ052_N_QueensIITest1()
        {
            int result = new OJ052_N_QueensII().TotalNQueens(8);
            Assert.AreEqual(92, result);
        }
    }
}
