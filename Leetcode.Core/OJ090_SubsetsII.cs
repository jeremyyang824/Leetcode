using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a collection of integers that might contain duplicates, nums, return all possible subsets.
     * Note:
     * Elements in a subset must be in non-descending order.
     * The solution set must not contain duplicate subsets.
     * 
     * For example,
     * If nums = [1,2,2], a solution is:
     * [
     *  [2],
     *  [1],
     *  [1,2,2],
     *  [2,2],
     *  [1,2],
     *  []
     * ]
     */
    public class OJ090_SubsetsII
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
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
                //重复比较
                for (int i = 0; i < result.Count; i++)
                {
                    IList<int> exists = result[i];
                    if (arrayEquals(exists, item))
                        return;
                }

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

        private bool arrayEquals(IList<int> a, IList<int> b)
        {
            if (a.Count != b.Count)
                return false;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
    }
}
