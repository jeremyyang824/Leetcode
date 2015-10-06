using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * You are given a string, s, and a list of words, words, that are all of the same length. 
     * Find all starting indices of substring(s) in s that is a concatenation of each word in words exactly once and without any intervening characters.
     * For example, given:
     * s: "barfoothefoobarman"
     * words: ["foo", "bar"]
     * You should return the indices: [0,9].
     * (order does not matter).
     */
    public class OJ030_SubstringWithConcatenationOfAllWords
    {
        /*
         * 这道题看似比较复杂，其实思路和Longest Substring Without Repeating Characters差不多。
         * 因为那些单词是定长的，所以本质上和单一个字符一样。
         * 和Longest Substring Without Repeating Characters的区别只在于我们需要维护一个字典，然后保证目前的串包含字典里面的单词有且仅有一次。
         * 思路仍然是维护一个窗口，如果当前单词在字典中，则继续移动窗口右端，否则窗口左端可以跳到字符串下一个单词了。
         * 
         * 假设源字符串的长度为n，字典中单词的长度为l。因为不是一个字符，所以我们需要对源字符串所有长度为l的子串进行判断。
         * 做法是i从0到l-1个字符开始，得到开始index分别为i, i+l, i+2*l, ...的长度为l的单词。这样就可以保证判断到所有的满足条件的串。
         * 因为每次扫描的时间复杂度是O(2*n/l)(每个单词不会被访问多于两次，一次是窗口右端，一次是窗口左端)，总共扫描l次（i=0, ..., l-1)，所以总复杂度是O(2*n/l*l)=O(n)，是一个线性算法。
         * 空间复杂度是字典的大小，即O(m*l)，其中m是字典的单词数量。
         */
        public IList<int> FindSubstring(string s, string[] words)
        {
            List<int> result = new List<int>();
            if (s == null || s.Length == 0 || words == null || words.Length == 0)
                return result;

            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (map.ContainsKey(words[i]))
                    map[words[i]] = map[words[i]] + 1;
                else
                    map.Add(words[i], 1);
            }

            int len = words[0].Length;  //固定长度
            for (int i = 0; i < len; i++)
            {
                Dictionary<string, int> curMap = new Dictionary<string, int>();

                int count = 0;
                int left = i;   //滑动窗口左边界
                for (int j = i; j <= s.Length - len; j += len)
                {
                    string str = s.Substring(j, len);

                    if (map.ContainsKey(str))
                    {
                        if (curMap.ContainsKey(str))
                            curMap[str] = curMap[str] + 1;
                        else
                            curMap.Add(str, 1);

                        if (curMap[str] <= map[str])
                            count++;
                        else
                        {
                            while (curMap[str] > map[str])
                            {
                                string temp = s.Substring(left, len);
                                if (curMap.ContainsKey(temp))
                                {
                                    curMap[temp] = curMap[temp] - 1;
                                    if (curMap[temp] < map[temp])
                                        count--;
                                }
                                left += len;
                            }
                        }

                        if (count == words.Length)
                        {
                            result.Add(left);
                            string temp = s.Substring(left, len);
                            if (curMap.ContainsKey(temp))
                                curMap[temp] = curMap[temp] - 1;
                            count--;
                            left += len;
                        }
                    }
                    else
                    {
                        curMap.Clear();
                        count = 0;
                        left = j + len;
                    }
                }
            }

            return result;
        }
    }
}
