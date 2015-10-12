using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a collection of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
     * Each number in C may only be used once in the combination.
     * Note:
     * All numbers (including target) will be positive integers.
     * Elements in a combination (a1, a2, … , ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
     * The solution set must not contain duplicate combinations.
     * For example, given candidate set 10,1,2,7,6,1,5 and target 8, 
     * A solution set is: 
     * [1, 7] 
     * [1, 2, 5] 
     * [2, 6] 
     * [1, 1, 6] 
     */
    public class OJ040_CombinationSumII
    {
        //1, 1, 2, 5, 6, 7, 10
        private int[] arr;
        private IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            if (candidates.Length < 1)
                return result;

            Array.Sort(candidates, 0, candidates.Length);
            arr = candidates;
            this.dfs(new List<int>(), 0, target, 0);
            return result;
        }

        private void dfs(List<int> tmp, int tmpSum, int target, int startIdx)
        {
            if (tmpSum == target)
            {
                int[] res = new int[tmp.Count];
                tmp.CopyTo(res);
                result.Add(res);
                return; //剪枝，因为升序排列，后面的数字一定的大于当前值
            }
            else if (tmpSum > target)
            {
                return; //剪枝，因为升序排列，后面的数字一定的大于当前值
            }
            else
            {
                for (int i = startIdx; i < arr.Length; i++)
                {
                    if (i > startIdx && arr[i] == arr[i - 1])
                        continue;   //去除重复数字，重复数字可导致重复结果

                    tmp.Add(arr[i]);
                    this.dfs(tmp, tmpSum + arr[i], target, i + 1);  //不可重复，i+1
                    tmp.RemoveAt(tmp.Count - 1);
                }
            }
        }
    }
}
