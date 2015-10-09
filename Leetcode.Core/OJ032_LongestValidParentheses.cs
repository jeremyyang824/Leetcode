using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
     * For "(()", the longest valid parentheses substring is "()", which has length = 2.
     * Another example is ")()())", where the longest valid parentheses substring is "()()", which has length = 4.
     */
    public class OJ032_LongestValidParentheses
    {
        public int LongestValidParentheses(string s)
        {
            Stack<int> stack = new Stack<int>();
            char[] arr = s.ToCharArray();
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    if (stack.Count != 0 && arr[stack.Peek()] == '(')
                    {
                        stack.Pop();
                        result = Math.Max((stack.Count == 0 ? i + 1 : i - stack.Peek()), result);
                    }
                    else
                    {
                        stack.Push(i);
                    }
                }
            }
            return result;
        }
    }
}
