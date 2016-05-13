using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /**
     * Given a string s, partition s such that every substring of the partition is a palindrome.
     * Return all possible palindrome partitioning of s.
     * 
     * For example, given s = "aab",
     * Return
     *   [
     *     ["aa","b"],
     *     ["a","a","b"]
     *   ]
     */
    public class OJ131_PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> result = new List<IList<string>>();
            IList<string> list = new List<string>();
            if (s == null || s.Length < 1)
                return result;

            this.dfs(result, list, s);
            return result;
        }

        private void dfs(IList<IList<string>> result, IList<string> list, string s)
        {
            //当传入的字符串长度等于0，则这个集合分割list满足条件
            int len = s.Length;
            if (len < 1)
            {
                result.Add(new List<string>(list)); //复制list并保存
                return;
            }

            for (int i = 1; i <= len; i++)
            {
                string leftStr = s.Substring(0, i);
                if (this.isPalindrome(leftStr))
                {
                    list.Add(leftStr);
                    string rightStr = s.Substring(i);
                    dfs(result, list, rightStr);
                    list.RemoveAt(list.Count - 1);  //该拆分失败，回溯上一轮
                }
            }
        }

        private bool isPalindrome(string s)
        {
            int i = 0,
                j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }


        /// <summary>
        /// 通过DP改进算法
        /// 利用一个二维表存放某个字符到另一个字符之间是否是回文
        /// </summary>
        public IList<IList<string>> Partition2(string s)
        {
            IList<IList<string>> result = new List<IList<string>>();
            IList<string> list = new List<string>();
            if (s == null || s.Length < 1)
                return result;

            int len = s.Length;
            bool[,] isPalTable = new bool[len, len];
            this.buildPalTable(isPalTable, s, len);

            this.dfs2(result, list, s, isPalTable, 0);
            return result;
        }

        private void dfs2(IList<IList<string>> result, IList<string> list, string s, bool[,] isPalTable, int pos)
        {
            if (pos == s.Length)
            {
                result.Add(new List<string>(list)); //复制list并保存
                return;
            }

            int len = s.Length - pos;   //待计算区域的长度 
            for (int i = 1; i <= len; i++)  //i为分隔后左串长度
            {
                /**
                 * s为原始字符串，其中[pos, pos+i-1]为当前计算轮的左串，在左串为回文的前提下，计算剩余右串(从pos+i的位置开始)的分割方法
                 */
                if (isPalTable[pos, pos + i - 1])
                {
                    list.Add(s.Substring(pos, i));
                    this.dfs2(result, list, s, isPalTable, pos + i);    //注意传入原始字符串
                    list.RemoveAt(list.Count - 1);
                }
            }
        }

        public void buildPalTable(bool[,] isPalTable, string s, int len)
        {
            for (int i = 0; i < len; i++)
            {
                isPalTable[i, i] = true;
            }

            //按间距从小到大计算
            for (int dis = 1; dis <= len; dis++)
            {
                for (int i = 0, j = i + dis; j < len; i++, j++)
                {
                    bool innerPal = true;
                    if (i + 1 < j - 1)
                        innerPal = isPalTable[i + 1, j - 1];

                    //由于间距是从小到大计算，因此内部字符串一定已经计算过
                    isPalTable[i, j] = innerPal && (s[i] == s[j]);
                }
            }
        }
    }
}
