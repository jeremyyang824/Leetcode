using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array S of n integers, are there elements a, b, c, and d in S such that a + b + c + d = target? 
     * Find all unique quadruplets in the array which gives the sum of target.
     * 
     * Note:
     * Elements in a quadruplet (a,b,c,d) must be in non-descending order. (ie, a ≤ b ≤ c ≤ d)
     * The solution set must not contain duplicate quadruplets.
     * 
     * For example, given array S = {1 0 -1 0 -2 2}, and target = 0.
     * A solution set is:
     * (-1,  0, 0, 1)
     * (-2, -1, 1, 2)
     * (-2,  0, 0, 2)
     */
    public class OJ018_FourSum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 4)
                return result;

            this.insertSort(nums, nums.Length);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1])
                    continue;   //duplication

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j != i + 1 && nums[j] == nums[j - 1])
                        continue;   //duplication

                    //2sum
                    int k = j + 1, l = nums.Length - 1;
                    while (k < l)
                    {
                        int sum = nums[i] + nums[j] + nums[k] + nums[l];
                        if (sum == target)
                        {
                            result.Add(new int[] { nums[i], nums[j], nums[k], nums[l] });

                            while (++k < l && nums[k] == nums[k - 1])
                                ;
                            while (k < --l && nums[l] == nums[l + 1])
                                ;
                        }
                        else if (sum < target)
                            k++;
                        else
                            l--;
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
