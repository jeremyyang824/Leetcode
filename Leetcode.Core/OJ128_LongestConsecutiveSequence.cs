using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
     * 
     * For example,
     * Given [100, 4, 200, 1, 3, 2],
     * The longest consecutive elements sequence is [1, 2, 3, 4]. Return its length: 4.
     * Your algorithm should run in O(n) complexity.
     */
    public class OJ128_LongestConsecutiveSequence
    {
        //set担当了2个职责：1)提供索引；2)确定该元素是否未被访问过
        //因为每个元素只会进一次set，在set中被访问一次，出一次set，因此时间复杂度是O(n)
        HashSet<int> set = new HashSet<int>();
        public int LongestConsecutive(int[] nums)
        {
            foreach (int n in nums)
                set.Add(n);

            int maxLen = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int ascMax = this.findConsecutiveNums(nums[i], 1);
                int descMax = this.findConsecutiveNums(nums[i] - 1, -1);

                if (ascMax + descMax > maxLen)
                    maxLen = ascMax + descMax;
            }
            return maxLen;
        }

        private int findConsecutiveNums(int val, int step)
        {
            int maxLen = 0;
            while (set.Contains(val))
            {
                maxLen++;
                set.Remove(val);    //注：通过该语句避免重复检测！(访问过则移除)
                val += step;
            }
            return maxLen;
        }
    }
}
