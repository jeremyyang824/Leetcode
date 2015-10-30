using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ054_SpiralMatrixTest
    {
        [TestMethod]
        public void OJ054_SpiralMatrixTest1()
        {
            IList<int> result = new OJ054_SpiralMatrix().SpiralOrder(new int[,]{
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            });
            ArrayAssert.AreEqual(new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 }, result.ToArray());
        }
    }
}
