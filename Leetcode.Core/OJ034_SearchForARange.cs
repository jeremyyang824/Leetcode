using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a sorted array of integers, find the starting and ending position of a given target value.
     * Your algorithm's runtime complexity must be in the order of O(log n).
     * If the target is not found in the array, return [-1, -1].
     * 
     * For example,
     * Given [5, 7, 7, 8, 8, 10] and target value 8,
     * return [3, 4].
     */
    public class OJ034_SearchForARange
    {
        private int minIdx = -1;
        private int maxIdx = -1;

        public int[] SearchRange(int[] nums, int target)
        {
            this.binarySearch(nums, 0, nums.Length - 1, target);
            return new int[] { minIdx, maxIdx };
        }

        private void binarySearch(int[] nums, int left, int right, int target)
        {
            if (left > right)
                return;

            int mid = (left + right) / 2;
            int midVal = nums[mid];
            if (midVal == target)
            {
                if (this.minIdx < 0 || mid < this.minIdx)
                    this.minIdx = mid;
                if (this.minIdx < 0 || mid > this.maxIdx)
                    this.maxIdx = mid;
            }

            if (midVal >= target)
            {
                binarySearch(nums, left, mid - 1, target);
            }
            if (midVal <= target)
            {
                binarySearch(nums, mid + 1, right, target);
            }
        }
    }
}
