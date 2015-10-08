using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Implement next permutation, which rearranges numbers into the lexicographically next greater permutation of numbers.
     * If such arrangement is not possible, it must rearrange it as the lowest possible order (ie, sorted in ascending order).
     * The replacement must be in-place, do not allocate extra memory.
     * Here are some examples. Inputs are in the left-hand column and its corresponding outputs are in the right-hand column.
     * 
     * 1,2,3 → 1,3,2
     * 3,2,1 → 1,2,3
     * 1,1,5 → 1,5,1
     */
    public class OJ031_NextPermutation
    {
        /*
         * 1.从右往左遍历，找到第一对“降序”对i和i+1（升序意味着交换只会使数字变小）
         * 2.从右往左遍历，找到第一个比i大的值j（i+1~n为降序，因此j一定是比i大的最小值） 
         * 3.交换i和j（交换后i+1~n仍然为降序，因为j<i且 j > j+1~n && j < i+1 ~ j-1）
         * 4.反转i+1~n（反转之后变为升序，升序意味着最小）
         */
        public void NextPermutation(int[] nums)
        {
            int len = nums.Length;
            if (len < 2)
                return;

            int i, j;
            for (i = len - 2; i >= 0; i--)
            {
                if (nums[i] < nums[i + 1])
                    break;
            }

            if (i >= 0)
            {
                for (j = len - 1; j > i; j--)
                {
                    if (nums[j] > nums[i])
                        break;
                }

                int t = nums[j];
                nums[j] = nums[i];
                nums[i] = t;
            }

            for (int a = i + 1, b = len - 1; a < b; a++, b--)
            {
                int t = nums[a];
                nums[a] = nums[b];
                nums[b] = t;
            }
        }
    }
}
