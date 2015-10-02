using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? 
     * Find all unique triplets in the array which gives the sum of zero.
     * 
     * Note:
     * Elements in a triplet (a,b,c) must be in non-descending order. (ie, a ≤ b ≤ c)
     * The solution set must not contain duplicate triplets.
     * 
     * For example, given array S = { -1 0 1 2 -1 -4 },
     * A solution set is:
     * (-1, 0, 1)
     * (-1, -1, 2)
     * 
     * 注：
     * 排好序以后的数字是 a b c d e f, 那么第一次枚举a, 在剩下的b c d e f中进行2 sum, 
     * 完了以后第二次枚举b, 只需要在 c d e f中进行2sum好了，而不是在a c d e f中进行2sum。
     */
    public class OJ015_ThreeSum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            this.insertSort(nums, nums.Length);

            int target = 0;
            List<IList<int>> result = new List<IList<int>>();
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
                        result.Add(new int[] { x, nums[j], nums[k] });

                        while (++j < k && nums[j] == nums[j - 1])
                            ;
                        while (j < --k && nums[k] == nums[k + 1])
                            ;
                    }
                    else if (sum < twoTarget)
                        j++;
                    else
                        k--;
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
