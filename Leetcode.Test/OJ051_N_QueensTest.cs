using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ051_N_QueensTest
    {
        [TestMethod]
        public void OJ051_N_QueensTest1()
        {
            IList<IList<string>> result = new OJ051_N_Queens().SolveNQueens(4);
            Assert.AreEqual(2, result.Count);

            ArrayAssert.AreEqual(new string[] { ".Q..", "...Q", "Q...", "..Q." }, result[0].ToArray());
            ArrayAssert.AreEqual(new string[] { "..Q.", "Q...", "...Q", ".Q.." }, result[1].ToArray());
        }
    }
}
