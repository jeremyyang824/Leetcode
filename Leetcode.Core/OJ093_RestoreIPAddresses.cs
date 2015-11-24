using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string containing only digits, restore it by returning all possible valid IP address combinations.
     * For example:
     * Given "25525511135",
     * return ["255.255.11.135", "255.255.111.35"]. (Order does not matter)
     */
    public class OJ093_RestoreIPAddresses
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            IList<string> result = new List<string>();
            if (s.Length < 4 || s.Length > 12)
                return result;

            this.restoreIP(result, new List<string>(), 0, 0, s);
            return result;
        }

        private void restoreIP(IList<string> result, List<string> ips, int kth, int start, string s)
        {
            if (start == s.Length)
            {
                if (kth == 4)
                {
                    string ip = string.Join(".", ips.ToArray());
                    result.Add(ip);
                }
                return;
            }

            //最多3位
            for (int k = 1; k <= 3 && start + (k - 1) < s.Length; k++)
            {
                string num = s.Substring(start, k);
                if (this.isValid(num))
                {
                    ips.Add(num);
                    restoreIP(result, ips, kth + 1, start + k, s);
                    ips.RemoveAt(ips.Count - 1);
                }
            }
        }

        private bool isValid(string num)
        {
            int numVal = int.Parse(num);
            if (num.Length == 1 && numVal >= 0 && numVal <= 9)
                return true;
            if (num.Length == 2 && numVal >= 10 && numVal <= 99)
                return true;
            if (num.Length == 3 && numVal >= 100 && numVal <= 255)
                return true;
            return false;
        }
    }
}
