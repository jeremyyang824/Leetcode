using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given n, generate all structurally unique BST's (binary search trees) that store values 1...n.
     * For example,
     * Given n = 3, your program should return all 5 unique BST's shown below.
     */
    public class OJ095_UniqueBinarySearchTreesII
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n < 1)
                return new List<TreeNode>();
            return this.generateTrees(1, n);
        }

        private List<TreeNode> generateTrees(int left, int right)
        {
            List<TreeNode> trees = new List<TreeNode>();

            if (left > right)
            {
                trees.Add(null);
                return trees;
            }
           
            for (int i = left; i <= right; i++)
            {
                List<TreeNode> leftTrees = this.generateTrees(left, i - 1);     //左子树可能性
                List<TreeNode> rightTrees = this.generateTrees(i + 1, right);   //右子树可能性

                //构建以i为根的树
                for (int j = 0; j < leftTrees.Count; j++)
                {
                    for (int k = 0; k < rightTrees.Count; k++)
                    {
                        TreeNode currentTree = new TreeNode(i);
                        currentTree.left = leftTrees[j];
                        currentTree.right = rightTrees[k];

                        trees.Add(currentTree);
                    }
                }
            }
            return trees;
        }

    }
}
