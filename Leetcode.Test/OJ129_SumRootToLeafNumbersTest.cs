using System;
using System.Collections.Generic;
using System.Linq;
using Leetcode.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode.Test
{
    [TestClass]
    public class OJ129_SumRootToLeafNumbersTest
    {
        [TestMethod]
        public void OJ129_SumRootToLeafNumbersTest1()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            int sum = new OJ129_SumRootToLeafNumbers().SumNumbers(root);
            Assert.AreEqual(25, sum);
        }
    }
}
