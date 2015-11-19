using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string s1, we may represent it as a binary tree by partitioning it to two non-empty substrings recursively.
     * Below is one possible representation of s1 = "great":
     *     great
     *    /    \
     *   gr    eat
     *  / \    /  \
     * g   r  e   at
     *            / \
     *           a   t 
     * To scramble the string, we may choose any non-leaf node and swap its two children.
     * For example, if we choose the node "gr" and swap its two children, it produces a scrambled string "rgeat".
     *     rgeat
     *    /    \
     *   rg    eat
     *  / \    /  \
     * r   g  e   at
     *            / \
     *           a   t
     * We say that "rgeat" is a scrambled string of "great".
     * Similarly, if we continue to swap the children of nodes "eat" and "at", it produces a scrambled string "rgtae".
     *     rgtae
     *    /    \
     *   rg    tae
     *  / \    /  \
     * r   g  ta  e
     *        / \
     *       t   a
     * We say that "rgtae" is a scrambled string of "great".
     * Given two strings s1 and s2 of the same length, determine if s2 is a scrambled string of s1.
     */
    public class OJ087_ScrambleString
    {
        /*
         * 字符串长度为1：很明显，两个字符串必须完全相同才可以。
         * 字符串长度为2：当s1="ab", s2只有"ab"或者"ba"才可以。
         * 对于任意长度的字符串，我们可以把字符串s1分为a1,b1两个部分，s2分为a2,b2两个部分，满足（(a1~a2) && (b1~b2)）或者 （(a1~b2) && (a1~b2)）
         */
        public bool IsScramble(string s1, string s2)
        {
            if (s1.Equals(s2))
                return true;

            int len = s1.Length;
            if (len != s2.Length)
                return false;

            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            /*
             * 第1维：子串长度
             * 第2维：s1长度
             * 第3维: s2长度
             * scrambled[k][i][j]表示s1[i...i+k]是否可以由s2[j...j+k]变化得来
             */
            bool[, ,] scrambled = new bool[len, len, len];
            for (int i = 0; i < len; ++i)
            {
                for (int j = 0; j < len; ++j)
                {
                    scrambled[0, i, j] = (c1[i] == c2[j]);
                }
            }

            for (int k = 2; k <= len; ++k)
            {
                for (int i = len - k; i >= 0; --i)
                {
                    for (int j = len - k; j >= 0; --j)
                    {
                        bool r = false;
                        for (int m = 1; m < k && !r; ++m)
                        {
                            r = (scrambled[m - 1, i, j] && scrambled[k - m - 1, i + m, j + m])
                                || (scrambled[m - 1, i, j + k - m] && scrambled[k - m - 1, i + m, j]);
                        }
                        scrambled[k - 1, i, j] = r;
                    }
                }
            }
            return scrambled[len - 1, 0, 0];
        }
    }
}
