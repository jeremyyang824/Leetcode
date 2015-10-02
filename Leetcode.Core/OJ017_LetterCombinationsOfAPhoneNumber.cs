using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a digit string, return all possible letter combinations that the number could represent.
     * A mapping of digit to letters (just like on the telephone buttons) is given below.
     * 
     * 1        2       3
     *          abc     def
     * 4        5       6
     * ghi      jkl     mno
     * 7        8       9
     * pqrs     tuv     wxyz
     * 
     * Input:Digit string "23"
     * Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
     * 
     * Note:
     * Although the above answer is in lexicographical order, your answer could be in any order you want.
     */
    public class OJ017_LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            List<string> result = new List<string>();
            if (digits.Length < 1)
                return result;

            Dictionary<char, char[]> dic = new Dictionary<char, char[]>();
            dic.Add('2', new char[] { 'a', 'b', 'c' });
            dic.Add('3', new char[] { 'd', 'e', 'f' });
            dic.Add('4', new char[] { 'g', 'h', 'i' });
            dic.Add('5', new char[] { 'j', 'k', 'l' });
            dic.Add('6', new char[] { 'm', 'n', 'o' });
            dic.Add('7', new char[] { 'p', 'q', 'r', 's' });
            dic.Add('8', new char[] { 't', 'u', 'v' });
            dic.Add('9', new char[] { 'w', 'x', 'y', 'z' });


            char[] temp = new char[digits.Length];
            this.dfs(digits, 0, temp, result, dic);
            return result;
        }

        private void dfs(string digits, int i, char[] temp, List<string> result, Dictionary<char, char[]> dic)
        {
            if (i == digits.Length)
            {
                result.Add(new string(temp));
                return;
            }

            char d = digits[i];
            foreach (char c in dic[d])
            {
                temp[i] = c;
                this.dfs(digits, i + 1, temp, result, dic);
            }
        }
    }
}
