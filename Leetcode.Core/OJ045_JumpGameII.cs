using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array of non-negative integers, you are initially positioned at the first index of the array.
     * Each element in the array represents your maximum jump length at that position.
     * Your goal is to reach the last index in the minimum number of jumps.
     * 
     * For example:
     * Given array A = [2,3,1,1,4]
     * The minimum number of jumps to reach the last index is 2. (Jump 1 step from index 0 to 1, then 3 steps to the last index.)
     */
    public class OJ045_JumpGameII
    {
        /*
         * 找出所有1次能到达的位置
         * 找出所有2次能到达的位置（从1次到达的位置出发能到达的“未知”位置）
         * ...
         */ 
        public int Jump(int[] nums)
        {
            int len = nums.Length;
            if (nums == null || len < 1)
                return 0;

            int[] map = new int[len];   //到达每个位置的最小步数

            int max = 0; //当前可达最大位置
            for (int i = 0; i < len; i++)
            {
                //更新本次新探索到的（从i可达的）位置的最小步数（即map[i]+1次可达）
                while (max < i + nums[i] && max < len - 1)
                {
                    map[++max] = map[i] + 1;
                }
            }

            return map[len - 1];
        }
    }
}
