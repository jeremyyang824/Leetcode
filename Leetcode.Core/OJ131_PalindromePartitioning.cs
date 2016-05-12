using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
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
                result.Add(new List<string>(list)); //复制list并保存

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
    }
}
