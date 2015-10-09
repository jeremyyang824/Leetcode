using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Suppose a sorted array is rotated at some pivot unknown to you beforehand.
     * (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
     * You are given a target value to search. If found in the array return its index, otherwise return -1.
     * You may assume no duplicate exists in the array.
     */
    public class OJ033_SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (target == nums[mid])
                    return mid;

                //全部递增，标准二分法
                if (nums[left] <= nums[right])
                {
                    if (target < nums[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                //左边递增，右边断开
                else if (nums[left] <= nums[mid])
                {
                    if (target > nums[mid] || target < nums[left])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                //右边递增，左边断开
                else
                {
                    if (target < nums[mid] || target > nums[right])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
            }
            return -1;
        }
    }
}
