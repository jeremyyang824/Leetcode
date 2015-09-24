using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core.Extra
{
    /*
     * Tag：Backtracking DFS
     */
    public class EightQueensPuzzle
    {
        private List<string> result = new List<string>();
        public string[] Result
        {
            get { return this.result.ToArray(); }
        }

        private int num = 8;
        private int[] queen;

        public EightQueensPuzzle()
        {
            this.queen = new int[num];
        }

        public void EightQueen()
        {
            this.eightQueen(1);
        }

        private void eightQueen(int row)
        {
            if (row > this.num)
            {
                this.setResult();
            }
            else
            {
                for (int col = 1; col <= num; col++)
                {
                    if (this.place(row, col))
                    {
                        this.queen[row - 1] = col;
                        this.eightQueen(row + 1);
                    }
                }
            }
        }

        private bool place(int row, int col)
        {
            for (int r = 1; r < row; r++)   //注意：x中只检测1~row-1，因此每次找到一个解时无需清理x
            {
                int c = this.queen[r - 1];
                if (c == col || Math.Abs(row - r) == Math.Abs(col - c))
                    return false;
            }
            return true;
        }

        private void setResult()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < queen.Length; i++)
            {
                sb.Append((queen[i]).ToString()).Append(",");
            }
            sb.Length = sb.Length - 1;

            this.result.Add(sb.ToString());
        }

    }
}
