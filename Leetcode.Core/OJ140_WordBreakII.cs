using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    public class OJ140_WordBreakII
    {
        public IList<string> WordBreak(string s, HashSet<string> wordDict)
        {
            List<string>[] dp = new List<string>[s.Length + 1];
            dp[0] = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                //i是开始位置
                if (dp[i] == null) continue; //前面的部分必须是可以匹配的
                foreach (string word in wordDict)
                {
                    int len = word.Length;
                    int end = i + len;
                    if (end > s.Length)
                        continue;
                    if (s.Substring(i, len) == word)
                    {
                        if (dp[end] == null)
                        {
                            dp[end] = new List<string>();
                        }
                        dp[end].Add(word);//记录上一个位置
                    }
                }
            }

            List<string> ans = new List<string>();
            if (dp[s.Length] == null)
                return ans;

            List<string> tmp = new List<string>();
            dfsStringList(dp, s.Length, ans, tmp);
            return ans;
        }

        private void dfsStringList(List<string>[] dp, int end, List<string> res, List<string> tmp)
        {
            if (end <= 0)
            {
                string ans = tmp[tmp.Count - 1];
                for (int i = tmp.Count - 2; i >= 0; i--)
                    ans += (" " + tmp[i]);
                res.Add(ans);
                return;
            }

            foreach (String str in dp[end])
            {
                tmp.Add(str);
                dfsStringList(dp, end - str.Length, res, tmp);
                tmp.RemoveAt(tmp.Count - 1);
            }
        }
    }
}
