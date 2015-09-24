using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). 
     * n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). 
     * Find two lines, which together with x-axis forms a container, such that the container contains the most water.
     * Note: You may not slant the container.
     * 
     * 贪心算法：类似于2Sum的思想，两边设一个指针，然后计算area，如果height[i] <= height[j]，那么i++，因为在这里height[i]是瓶颈，j往里移只会减少面积，不会再增加area。
     */
    public class OJ011_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int area = 0;
            int i = 0, j = height.Length - 1;
            while (i < j)
            {
                int tempArea = (j - i) * Math.Min(height[i], height[j]);
                if (tempArea > area)
                    area = tempArea;

                if (height[i] < height[j])
                    i++;
                else
                    j--;
            }
            return area;
        }
    }
}
