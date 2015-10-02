using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
     * The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
     */
    public class OJ020_ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length < 1)
                return true;

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                else if (c == ')')
                {
                    if (stack.Count < 1 || stack.Pop() != '(')
                        return false;
                }
                else if (c == '}')
                {
                    if (stack.Count < 1 || stack.Pop() != '{')
                        return false;
                }
                else if (c == ']')
                {
                    if (stack.Count < 1 || stack.Pop() != '[')
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
