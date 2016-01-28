using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ119_PascalsTriangleIITest
    {
        [TestMethod]
        public void OJ119_PascalsTriangleIITest1()
        {
            IList<int> result = new OJ119_PascalsTriangleII().GetRow(4);
            ArrayAssert.AreEqual(new int[] { 1, 4, 6, 4, 1 }, result.ToArray());
        }
    }
}
