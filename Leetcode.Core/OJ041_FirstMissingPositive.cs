using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an unsorted integer array, find the first missing positive integer.
     * 
     * For example,
     * Given [1,2,0] return 3,
     * and [3,4,-1,1] return 2.
     * Your algorithm should run in O(n) time and uses constant space.
     */
    public class OJ041_FirstMissingPositive
    {
        /*
         * 交换数组元素，使得数组中第i位存放数值(i+1)，寻找第一个不符合此要求的元素。
         */
        public int FirstMissingPositive(int[] nums)
        {
            if (nums == null || nums.Length < 1)
                return 1;

            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] > 0 && nums[i] < nums.Length
                    && nums[i] != i + 1
                    && nums[i] != nums[nums[i] - 1])
                {
                    int temp = nums[i];
                    nums[i] = nums[temp - 1];
                    nums[temp - 1] = temp;
                }
                else
                    i++;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                    return j + 1;
            }

            return i + 1;
        }
    }
}
