using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
     * For example, given the array [−2,1,−3,4,−1,2,1,−5,4],
     * the contiguous subarray [4,−1,2,1] has the largest sum = 6.
     */
    public class OJ053_MaximumSubarray
    {
        /*
         * 如果添加了第k+1这个元素，由于是连续子序列这个限制，所以如果k+1这个元素之前的和是小于0的，
         * 那么对于增大k+1这个元素从而去组成最大子序列是没有贡献的，所以可以把sum 置0。
         * 只要sum不减到负数，中间出现小于0的元素是没关系的，sum仍然可以继续累加。
         */
        public int MaxSubArray(int[] nums)
        {
            int sum = nums[0], maxSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (sum < 0)
                    sum = 0;
                sum = sum + nums[i];
                maxSum = Math.Max(sum, maxSum);
            }
            return maxSum;
        }
    }
}
