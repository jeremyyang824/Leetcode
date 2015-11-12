using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given two integers n and k, return all possible combinations of k numbers out of 1 ... n.
     * For example,
     * If n = 4 and k = 2, a solution is:
     * [[2,4],[3,4],[2,3],[1,2],[1,3],[1,4]]
     * 
     */
    public class OJ077_Combinations
    {
        /*
         * Cn.k =  n!/k!(n-k)!
         */
        public IList<IList<int>> Combine(int n, int k)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (n < 1 || k < 1)
                return result;

            List<int> item = new List<int>();
            this.combine(n, k, 1, 0, item, result);
            return result;
        }

        //start：开始的数；cur：已选择的数量
        private void combine(int n, int k, int start, int cur, List<int> item, List<IList<int>> result)
        {
            if (cur == k)
            {
                int[] itemClone = new int[item.Count];
                Array.Copy(item.ToArray(), itemClone, item.Count);
                result.Add(itemClone);
                return;
            }

            for (int i = start; i <= n; i++)
            {
                item.Add(i);
                combine(n, k, i + 1, cur + 1, item, result);    //DFS
                item.RemoveAt(item.Count - 1);                  //Backtrace
            }
        }
    }
}
