using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ075_SortColorsTest
    {
        [TestMethod]
        public void OJ075_SortColorsTest1()
        {
            int[] arr = new int[] { 1, 2, 1, 0, 0, 1, 2 };
            new OJ075_SortColors().SortColors(arr);
            ArrayAssert.AreEqual(new int[] { 0, 0, 1, 1, 1, 2, 2 }, arr);
        }
    }
}
