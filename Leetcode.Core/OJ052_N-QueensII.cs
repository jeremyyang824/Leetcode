using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Follow up for N-Queens problem.
     * Now, instead outputting board configurations, return the total number of distinct solutions.
     */
    public class OJ052_N_QueensII
    {
        private int total = 0;

        public int TotalNQueens(int n)
        {
            if (n < 1)
                return total;

            int[] solution = new int[n + 1];
            this.nQueens(1, n, solution);
            return total;
        }

        private void nQueens(int r, int n, int[] solution)
        {
            if (r > n)
            {
                this.total++;
                return;
            }

            for (int c = 1; c <= n; c++)
            {
                if (canPosition(r, c, solution))
                {
                    solution[r] = c;
                    this.nQueens(r + 1, n, solution);
                }
            }
        }

        private bool canPosition(int x, int y, int[] solution)
        {
            for (int r = 1; r < x; r++)
            {
                int c = solution[r];
                if (y == c || Math.Abs(x - r) == Math.Abs(y - c))
                    return false;
            }
            return true;
        }
    }
}
