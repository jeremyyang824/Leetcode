using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a set of distinct integers, nums, return all possible subsets.
     * Note:
     * Elements in a subset must be in non-descending order.
     * The solution set must not contain duplicate subsets.
     * 
     * For example,
     * If nums = [1,2,3], a solution is:
     * [[3],[1],[2],[1,2,3],[1,3],[2,3],[1,2],[]]
     */
    public class OJ078_Subsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(nums);

            this.subsets(nums, new List<int>(), 0, result);
            return result;
        }

        private void subsets(int[] nums, List<int> item, int level, IList<IList<int>> result)
        {
            if (level == nums.Length)
            {
                int[] itemClone = new int[item.Count];
                Array.Copy(item.ToArray(), itemClone, item.Count);
                result.Add(itemClone);

                return;
            }

            //不选择
            subsets(nums, item, level + 1, result);

            //选择
            item.Add(nums[level]);
            subsets(nums, item, level + 1, result);
            item.RemoveAt(item.Count - 1);  //！
        }
    }
}
