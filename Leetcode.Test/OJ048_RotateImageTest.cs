using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ048_RotateImageTest
    {
        [TestMethod]
        public void OJ048_RotateImageTest1()
        {
            int[,] img = new int[,] { 
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16},
            };
            new OJ048_RotateImage().Rotate(img);

            int[,] expected = new int[,] { 
                {13, 9, 5, 1},
                {14, 10, 6, 2},
                {15, 11, 7, 3},
                {16, 12, 8, 4},
            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(expected[i, j], img[i, j]);
                }
            }
        }
    }
}
