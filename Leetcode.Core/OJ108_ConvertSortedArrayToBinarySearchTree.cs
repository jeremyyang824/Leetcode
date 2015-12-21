using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
     */
    public class OJ108_ConvertSortedArrayToBinarySearchTree
    {
        /*
         * 给定一个区间[left, right]，取其中值mid=(left+right)/2对应的元素作为二叉树的根。
         * 二叉树的左子树根的值为对[left, mid-1]继续操作的结果，右子树类似。
         */
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
                return null;
            return this.generateBST(nums, 0, nums.Length - 1);
        }

        private TreeNode generateBST(int[] nums, int left, int right)
        {
            if (left > right)
                return null;

            int mid = (left + right) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = this.generateBST(nums, left, mid - 1);
            node.right = this.generateBST(nums, mid + 1, right);
            return node;
        }
    }
}
