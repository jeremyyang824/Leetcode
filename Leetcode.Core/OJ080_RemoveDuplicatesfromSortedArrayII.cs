using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Follow up for "Remove Duplicates":
     * What if duplicates are allowed at most twice?
     * 
     * For example,
     * Given sorted array nums = [1,1,1,2,2,3],
     * Your function should return length = 5, with the first five elements of nums being 1, 1, 2, 2 and 3. 
     * It doesn't matter what you leave beyond the new length.
     */
    public class OJ080_RemoveDuplicatesfromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            int len = nums.Length;
            if (len < 1)
                return 0;
            if (len == 1) 
                return 1;

            int j = 1, i, temp = nums[1];
            for (i = 2; i < len; ++i)
            {
                if (nums[i] != nums[i - 2])
                {
                    nums[j++] = temp;
                    temp = nums[i]; //将下一个值先记录到temp变量中，避免重复检测
                }
            }
            nums[j++] = temp;
            return j;
        }
    }
}
