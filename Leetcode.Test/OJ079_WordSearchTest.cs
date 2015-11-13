using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ079_WordSearchTest
    {
        [TestMethod]
        public void OJ079_WordSearchTest1()
        {
            char[,] matrix = new char[,] {
                {'A', 'B', 'C', 'E'},
                {'S', 'F', 'C', 'S'},
                {'A', 'D', 'E', 'E'},
            };

            bool result1 = new OJ079_WordSearch().Exist(matrix, "ABCCED");
            Assert.AreEqual(true, result1);

            bool result2 = new OJ079_WordSearch().Exist(matrix, "SEE");
            Assert.AreEqual(true, result2);

            bool result3 = new OJ079_WordSearch().Exist(matrix, "ABCB");
            Assert.AreEqual(false, result3);
        }
    }
}
