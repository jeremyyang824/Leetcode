using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.
     * Do not allocate extra space for another array, you must do this in place with constant memory.
     * For example,
     * Given input array nums = [1,1,2],
     * Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. 
     * It doesn't matter what you leave beyond the new length.
     */
    public class OJ026_RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int len = nums.Length;
            if (len < 1)
                return 0;

            int i = 1;
            for (int j = 1; j < len; j++)
            {
                if (nums[j] != nums[j - 1])
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
    }
}
