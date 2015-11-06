using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given an array of words and a length L, format the text such that each line has exactly L characters and is fully (left and right) justified.
     * You should pack your words in a greedy approach; that is, pack as many words as you can in each line. 
     * Pad extra spaces ' ' when necessary so that each line has exactly L characters.
     * Extra spaces between words should be distributed as evenly as possible. 
     * If the number of spaces on a line do not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.
     * For the last line of text, it should be left justified and no extra space is inserted between words.
     * 
     * For example,
     * words: ["This", "is", "an", "example", "of", "text", "justification."]
     * L: 16.
     * Return the formatted lines as:
     * [
     *  "This    is    an",
     *  "example  of text",
     *  "justification.  "
     * ]
     * Note: Each word is guaranteed not to exceed L in length.
     * 
     * Corner Cases:
     * A line other than the last line might contain only one word. What should you do in this case?
     * In this case, that line should be left-justified.
     */
    public class OJ068_TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<String> res = new List<String>();
            if (words == null || words.Length == 0)
                return res;
            int count = 0;
            int last = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (count + words[i].Length + (i - last) > maxWidth)
                {
                    int spaceNum = 0;
                    int extraNum = 0;
                    if (i - last - 1 > 0)
                    {
                        spaceNum = (maxWidth - count) / (i - last - 1);
                        extraNum = (maxWidth - count) % (i - last - 1);
                    }
                    StringBuilder str = new StringBuilder();
                    for (int j = last; j < i; j++)
                    {
                        str.Append(words[j]);
                        if (j < i - 1)
                        {
                            for (int k = 0; k < spaceNum; k++)
                            {
                                str.Append(" ");
                            }
                            if (extraNum > 0)
                            {
                                str.Append(" ");
                            }
                            extraNum--;
                        }
                    }
                    for (int j = str.Length; j < maxWidth; j++)
                    {
                        str.Append(" ");
                    }
                    res.Add(str.ToString());
                    count = 0;
                    last = i;
                }
                count += words[i].Length;
            }
            StringBuilder str2 = new StringBuilder();
            for (int i = last; i < words.Length; i++)
            {
                str2.Append(words[i]);
                if (str2.Length < maxWidth)
                    str2.Append(" ");
            }
            for (int i = str2.Length; i < maxWidth; i++)
            {
                str2.Append(" ");
            }
            res.Add(str2.ToString());
            return res;
        }


    }
}
