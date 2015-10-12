using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a set of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T.
     * The same repeated number may be chosen from C unlimited number of times.
     * 
     * Note:
     * All numbers (including target) will be positive integers.
     * Elements in a combination (a1, a2, … , ak) must be in non-descending order. (ie, a1 ≤ a2 ≤ … ≤ ak).
     * The solution set must not contain duplicate combinations.
     * For example, given candidate set 2,3,6,7 and target 7, 
     * A solution set is: 
     * [7] 
     * [2, 2, 3] 
     */
    public class OJ039_CombinationSum
    {
        private int[] arr;
        private IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
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
                    tmp.Add(arr[i]);
                    this.dfs(tmp, tmpSum + arr[i], target, i);  //可重复，因此是i而非i+1
                    tmp.RemoveAt(tmp.Count - 1);
                }
            }
        }
    }
}
