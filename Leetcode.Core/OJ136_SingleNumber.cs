using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array of integers, every element appears twice except for one. Find that single one.
     * Note:
     * Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
     */
    public class OJ136_SingleNumber
    {
        /*
         * 思路：
         * 1. A XOR B = B XOR A 可交换
         * 2. A XOR A = 0 任何数与自己异或都为0
         * 3. A XOR 0 = A 任何数与0异或都为本身
         * 因此：
         * (2^1^4^5^2^4^1) = ((2^2)^(1^1)^(4^4)^(5)) = (0^0^0^5) = 5
         */
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
