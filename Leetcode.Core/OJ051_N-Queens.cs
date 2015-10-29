using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * The n-queens puzzle is the problem of placing n queens on an n×n chessboard such that no two queens attack each other.
     * Given an integer n, return all distinct solutions to the n-queens puzzle.
     * Each solution contains a distinct board configuration of the n-queens' placement, where 'Q' and '.' both indicate a queen and an empty space respectively.
     * For example,
     * There exist two distinct solutions to the 4-queens puzzle:
     * 
     * [
     *  [".Q..",  // Solution 1
     *   "...Q",
     *   "Q...",
     *   "..Q."],
     *  ["..Q.",  // Solution 2
     *   "Q...",
     *   "...Q",
     *   ".Q.."]
     * ]
     */
    public class OJ051_N_Queens
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> result = new List<IList<string>>();
            if (n < 1)
                return result;

            int[] solution = new int[n + 1];
            this.nQueens(1, n, solution, result);
            return result;
        }

        private void nQueens(int r, int n, int[] solution, List<IList<string>> result)
        {
            if (r > n)
            {
                string[] imgSolution = new string[n];
                for (int i = 1; i <= n; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    int pos = solution[i];
                    for (int j = 1; j <= n; j++)
                    {
                        if (j == pos)
                            sb.Append("Q");
                        else
                            sb.Append(".");
                    }
                    imgSolution[i - 1] = sb.ToString();
                }
                result.Add(imgSolution);
                return;
            }

            for (int c = 1; c <= n; c++)
            {
                if (canPosition(r, c, solution))
                {
                    solution[r] = c;
                    this.nQueens(r + 1, n, solution, result);
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
