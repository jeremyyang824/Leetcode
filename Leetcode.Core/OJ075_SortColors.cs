using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array with n objects colored red, white or blue, sort them so that objects of the same color are adjacent, 
     * with the colors in the order red, white and blue.
     * Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
     * 
     * Note:
     * You are not suppose to use the library's sort function for this problem.
     * 
     * Follow up:
     * A rather straight forward solution is a two-pass algorithm using counting sort.
     * First, iterate the array counting number of 0's, 1's, and 2's, then overwrite array with total number of 0's, then 1's and followed by 2's.
     * Could you come up with an one-pass algorithm using only constant space?
     */
    public class OJ075_SortColors
    {
        /*
         * 方法1：定义指针start = -1，指针end = n；一次遍历，如果遇到0，交换给start，遇到2，交换给end，遇到1不管。
         * 方法2：由于已知只有3种元素，那么通过3个指针可以记录3种元素的最后位置，每次遇到新元素，只需要交换i\j\k三个元素。
         */
        public void SortColors(int[] nums)
        {
            int i = -1; int j = -1; int k = -1;
            for (int p = 0; p < nums.Length; p++)
            {
                if (nums[p] == 0)
                {
                    nums[++k] = 2;
                    nums[++j] = 1;
                    nums[++i] = 0;
                }
                else if (nums[p] == 1)
                {
                    nums[++k] = 2;
                    nums[++j] = 1;
                }
                else
                {
                    nums[++k] = 2;
                }
            }
        }
    }
}
