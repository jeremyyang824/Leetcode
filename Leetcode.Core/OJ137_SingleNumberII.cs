using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    public class OJ137_SingleNumberII
    {
        /*
         * 思路1：
         *  int 数据共有32位，可以用32变量存储 这 N 个元素中各个二进制位上1出现的次数，
         *  最后在进行模3操作，如果为1，那说明这一位是要找元素二进制表示中为1的那一位。
         *  
         * 
         */
        public int SingleNumber(int[] nums)
        {
            int[] bitnum = new int[32];
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    bitnum[i] += (nums[j] >> i) & 1;
                }
                res |= (bitnum[i] % 3) << i;
            }
            return res;
        }
    }
}
