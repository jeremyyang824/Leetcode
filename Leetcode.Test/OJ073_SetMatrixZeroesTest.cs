using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ073_SetMatrixZeroesTest
    {
        [TestMethod]
        public void OJ073_SetMatrixZeroesTest1()
        {
            int[,] matrix = new int[,] { 
                {1, 0},
                {1, 1},
            };
            new OJ073_SetMatrixZeroes().SetZeroes(matrix);
            Assert.AreEqual(0, matrix[0, 0]);
            Assert.AreEqual(0, matrix[0, 1]);
            Assert.AreEqual(1, matrix[1, 0]);
            Assert.AreEqual(0, matrix[1, 1]);
        }
    }
}
