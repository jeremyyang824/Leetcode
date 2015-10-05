using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array and a value, remove all instances of that value in place and return the new length.
     * The order of elements can be changed. It doesn't matter what you leave beyond the new length.
     */
    public class OJ027_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int len = nums.Length;
            if (len < 1)
                return 0;

            int i = 0;
            for (int j = 0; j < len; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
    }
}
