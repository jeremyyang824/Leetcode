using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a collection of numbers that might contain duplicates, return all possible unique permutations.
     * For example,
     * [1,1,2] have the following unique permutations:
     * [1,1,2], [1,2,1], and [2,1,1].
     */
    public class OJ047_PermutationsII
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            //Array.Sort(nums, 0, nums.Length);   //sort
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
                if (isSwap(nums, pos, i))   //?
                {
                    this.swap(nums, pos, i);
                    this.permute(nums, pos + 1, result);
                    this.swap(nums, pos, i);
                }
            }
        }

        private bool isSwap(int[] nums, int a, int b)
        {
            for (int i = a; i < b; i++)
            {
                if (nums[i] == nums[b])
                    return false;
            }
            return true;
        }

        private void swap(int[] nums, int a, int b)
        {
            int temp = nums[a];
            nums[a] = nums[b];
            nums[b] = temp;
        }
    }
}
