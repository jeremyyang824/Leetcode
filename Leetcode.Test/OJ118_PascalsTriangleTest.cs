using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ118_PascalsTriangleTest
    {
        [TestMethod]
        public void OJ118_PascalsTriangleTest1()
        {
            IList<IList<int>> result = new OJ118_PascalsTriangle().Generate(5);
            ArrayAssert.AreEqual(new int[] { 1 }, result[0].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 1 }, result[1].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 2, 1 }, result[2].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 3, 3, 1 }, result[3].ToArray());
            ArrayAssert.AreEqual(new int[] { 1, 4, 6, 4, 1 }, result[4].ToArray());
        }
    }
}
