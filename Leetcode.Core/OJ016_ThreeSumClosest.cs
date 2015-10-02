using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target. 
     * Return the sum of the three integers. 
     * You may assume that each input would have exactly one solution.
     * 
     * For example, given array S = {-1 2 1 -4}, and target = 1.
     * The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
     */
    public class OJ016_ThreeSumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            this.insertSort(nums, nums.Length);

            int result = target;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1])
                    continue;   //duplication

                int x = nums[i];
                int twoTarget = target - x;

                //2sum
                int j = i + 1, k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[j] + nums[k];
                    if (sum == twoTarget)
                    {
                        return target;
                    }
                    else
                    {
                        if (result == target)
                            result = x + sum;
                        else
                        {
                            int a = target - (x + sum);
                            int b = target - result;
                            if (Math.Abs(a) < Math.Abs(b))
                                result = x + sum;
                        }

                        if (sum < twoTarget)
                            j++;
                        else
                            k--;
                    }
                }
            }
            return result;
        }

        private void insertSort(int[] arr, int n)
        {
            int temp;
            for (int i = 1; i < n; ++i)
            {
                temp = arr[i];
                int j;
                for (j = i; j > 0 && temp < arr[j - 1]; --j)
                {
                    arr[j] = arr[j - 1];
                }
                arr[j] = temp;
            }
        }
    }
}
