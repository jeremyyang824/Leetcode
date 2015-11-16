using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Follow up for "Search in Rotated Sorted Array":
     * What if duplicates are allowed?
     * Would this affect the run-time complexity? How and why?
     * Write a function to determine if a given target is in the array.
     */
    public class OJ081_SearchInRotatedSortedArrayII
    {
        public bool Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                    return true;

                //左边递增，右边断开
                if (nums[left] < nums[mid])
                {
                    if (nums[left] <= target && target < nums[mid])
                        right = mid - 1;
                    else
                        left = mid + 1;
                }
                //右边递增，左边断开
                else if (nums[mid] < nums[right])
                {
                    if (nums[mid] < target && target <= nums[right])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                else if (nums[left] == nums[mid])
                {
                    left++;
                }
                else if (nums[mid] == nums[right])
                {
                    right--;
                }
            }

            return false;
        }
    }
}
