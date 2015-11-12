using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ078_SubsetsTest
    {
        [TestMethod]
        public void OJ078_SubsetsTest1()
        {
            var result = new OJ078_Subsets().Subsets(new int[] { 1, 2, 3 })
                .ToArray();

            Assert.AreEqual(8, result.Length);
            ArrayAssert.AreEqual(new int[] { }, result[0].ToArray());
            ArrayAssert.AreEqual(new int[] { 3 }, result[1].ToArray());
            ArrayAssert.AreEqual(new int[] { 2 }, result[2].ToArray());
            ArrayAssert.AreEqual(new int[] { 2, 3 }, result[3].ToArray());
            ArrayAssert.AreEqual(new int[] { 1 }, result[4].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 3 }, result[5].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 2 }, result[6].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 2, 3 }, result[7].ToArray());
        }
    }
}
