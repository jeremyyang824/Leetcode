using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ130_SurroundedRegionsTest
    {
        [TestMethod]
        public void OJ130_SurroundedRegions1()
        {
            char[,] board = new char[,]{
                {'X','X','X','X'},
                {'X','O','O','X'},
                {'X','X','O','X'},
                {'X','O','X','X'}
            };
            new OJ130_SurroundedRegions().Solve(board);

            ArrayAssert.AreEqual(board, new char[,] { 
                {'X','X','X','X'},
                {'X','X','X','X'},
                {'X','X','X','X'},
                {'X','O','X','X'}
            });
        }
    }
}
