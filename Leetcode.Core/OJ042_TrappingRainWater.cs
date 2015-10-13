using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
     * For example, 
     * Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.
     */
    public class OJ042_TrappingRainWater
    {
        /*
         * 对某个值A[i]来说，能trapped的最多的water取决于在i之前最高的值leftMostHeight[i]和在i右边的最高的值rightMostHeight[i]（均不包含自身）。
         * 如果min(left,right) > A[i]，那么在i这个位置上能trapped的water就是min(left,right) – A[i]。
         */
        public int Trap(int[] height)
        {
            if (height == null || height.Length < 1)
                return 0;

            int len = height.Length;
            int maxHeight = 0;

            int[] leftMostHeight = new int[len];
            for (int i = 0; i < len; i++)
            {
                leftMostHeight[i] = maxHeight;

                if (height[i] > maxHeight)
                    maxHeight = height[i];
            }

            maxHeight = 0;
            int[] rightMostHeight = new int[len];
            for (int i = len - 1; i > 0; i--)
            {
                rightMostHeight[i] = maxHeight;

                if (height[i] > maxHeight)
                    maxHeight = height[i];
            }

            int total = 0;
            for (int i = 0; i < len; i++)
            {
                int h = Math.Min(leftMostHeight[i], rightMostHeight[i]) - height[i];
                if (h > 0)
                    total += h;
            }
            return total;
        }
    }
}
