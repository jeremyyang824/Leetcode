using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array of integers, find two numbers such that they add up to a specific target number.
     * The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2. 
     * Please note that your returned answers (both index1 and index2) are not zero-based.
     * 
     * You may assume that each input would have exactly one solution.
     * Input: numbers={2, 7, 11, 15}, target=9
     * Output: index1=1, index2=2
     */
    public class OJ001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    int index = map[target - nums[i]];
                    result[0] = index + 1;
                    result[1] = i + 1;
                    break;
                }
                else
                {
                    if (!map.ContainsKey(nums[i]))
                        map.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}
