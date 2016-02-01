using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ120_TriangleTest
    {
        [TestMethod]
        public void OJ120_TriangleTest1()
        {
            IList<IList<int>> triangle = new List<IList<int>>() { 
                new List<int>{ 2 },
                new List<int>{ 3, 4 },
                new List<int>{ 6, 5, 7 },
                new List<int>{ 4, 1, 8, 3 },
            };
            int result = new OJ120_Triangle().MinimumTotal(triangle);
            Assert.AreEqual(11, result);
        }
    }
}
