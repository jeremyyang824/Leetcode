using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array of non-negative integers, you are initially positioned at the first index of the array.
     * Each element in the array represents your maximum jump length at that position.
     * Determine if you are able to reach the last index.
     * 
     * For example:
     * A = [2,3,1,1,4], return true.
     * A = [3,2,1,0,4], return false.
     */
    public class OJ055_JumpGame
    {
        /*
        public bool CanJump(int[] nums)
        {
            if (nums.Length < 1)
                return false;

            int max = 1;  //当前能走到的最远位置
            for (int i = 0; i < max && i < nums.Length; i++)    //注：i<max限定了不能超过最大可达限制
            {
                max = Math.Max(nums[i] + i + 1, max);
                if (max >= nums.Length)
                    return true;
            }
            return false;
        }
        */

        public bool CanJump(int[] nums)
        {
            if (nums.Length < 1)
                return false;

            //当前点还可向前走几步
            int step = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (step > 0)
                {
                    step--;
                    step = Math.Max(nums[i], step);
                }
                else
                    return false;
            }
            return true;
        }
    }
}
