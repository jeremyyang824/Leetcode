using System;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ036_ValidSudokuTest
    {
        [TestMethod]
        public void OJ036_ValidSudokuTest1()
        {
            bool result = new OJ036_ValidSudoku().IsValidSudoku(new char[,] {
                {'5', '3', '.', '.', '7', '.','.', '.', '.'},
                {'6', '.', '.', '1', '9', '5','.', '.', '.'},
                {'.', '9', '8', '.', '.', '.','.', '6', '.'},
                {'8', '.', '.', '.', '6', '.','.', '.', '3'},
                {'4', '.', '.', '8', '.', '3','.', '.', '1'},
                {'7', '.', '.', '.', '2', '.','.', '.', '6'},
                {'.', '6', '.', '.', '.', '.','2', '8', '.'},
                {'.', '.', '.', '4', '1', '9','.', '.', '5'},
                {'.', '.', '.', '.', '8', '.','.', '7', '9'},
            });
            Assert.AreEqual(true, result);
        }
    }
}
