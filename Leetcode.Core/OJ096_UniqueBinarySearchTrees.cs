using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given n, how many structurally unique BST's (binary search trees) that store values 1...n?
     * For example,
     * Given n = 3, there are a total of 5 unique BST's.
     */
    public class OJ096_UniqueBinarySearchTrees
    {
        /*
        public int NumTrees(int n)
        {
            return this.numTrees(1, n);
        }

        public int numTrees(int a, int b)
        {
            if (a >= b)
                return 1;

            int total = 0;
            for (int i = a; i <= b; i++)
            {
                int left = this.numTrees(a, i - 1);
                int right = this.numTrees(i + 1, b);
                total += left * right;
            }
            return total;
        }
        */

        /*
         * map[i] = ∑(1...i)(map[0...k-1] * [k+1...i])
         */
        public int NumTrees(int n)
        {
            if (n < 2)
                return n;

            int[] map = new int[n + 1];
            map[0] = 1;
            map[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    map[i] += map[j - 1] * map[i - j];
                }
            }
            return map[n];
        }
    }
}
