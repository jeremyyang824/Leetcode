using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ074_Search2DMatrixTest
    {
        [TestMethod]
        public void OJ074_Search2DMatrixTest1()
        {
            int[,] matrix = new int[,]{
                {1, 3, 5, 7},
                {10, 11, 16, 20},
                {23, 30, 34, 50},
            };
            bool result = new OJ074_Search2DMatrix().SearchMatrix(matrix, 3);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ074_Search2DMatrixTest2()
        {
            int[,] matrix = new int[,]{
                {1, 3, 5, 7},
                {10, 11, 16, 20},
                {23, 30, 34, 50},
            };
            bool result = new OJ074_Search2DMatrix().SearchMatrix(matrix, 23);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void OJ074_Search2DMatrixTest3()
        {
            int[,] matrix = new int[,]{
                {1, 3, 5, 7},
                {10, 11, 16, 20},
                {23, 30, 34, 50},
            };
            bool result = new OJ074_Search2DMatrix().SearchMatrix(matrix, 31);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void OJ074_Search2DMatrixTest4()
        {
            int[,] matrix = new int[,]{
                {1},
            };
            bool result = new OJ074_Search2DMatrix().SearchMatrix(matrix, 0);
            Assert.AreEqual(false, result);
        }
    }
}
