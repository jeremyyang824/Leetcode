using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a collection of numbers, return all possible permutations.
     * For example,
     * [1,2,3] have the following permutations:
     * [1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], and [3,2,1].
     */
    public class OJ046_Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            this.permute(nums, 0, result);
            return result;
        }

        private void permute(int[] nums, int pos, IList<IList<int>> result)
        {
            if (pos == nums.Length)
            {
                int[] arr = new int[nums.Length];
                Array.Copy(nums, arr, nums.Length);
                result.Add(arr);
            }

            for (int i = pos; i < nums.Length; i++)
            {
                this.swap(nums, pos, i);
                this.permute(nums, pos + 1, result);
                this.swap(nums, pos, i);
            }
        }

        private void swap(int[] nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}
