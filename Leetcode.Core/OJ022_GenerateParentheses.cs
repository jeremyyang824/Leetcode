using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
     * For example, given n = 3, a solution set is:
     * "((()))", "(()())", "(())()", "()(())", "()()()"
     */
    public class OJ022_GenerateParentheses
    {
        /*
         * 假设在位置k我们还剩余left个左括号和right个右括号，如果left>0，则我们可以直接打印左括号，而不违背规则。
         * 能否打印右括号，我们还必须验证left和right的值是否满足规则，
         * 如果left>=right，则我们不能打印右括号，因为打印会违背合法排列的规则，否则可以打印右括号。
         * 如果left和right均为零，则说明我们已经完成一个合法排列，可以将其打印出来。
         */
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> result = new List<string>();
            this.generateParenthesis(n, n, "", result);
            return result;
        }

        private void generateParenthesis(int left, int right, string str, IList<string> result)
        {
            if (left == 0 && right == 0)
                result.Add(str);

            if (left > 0)
                this.generateParenthesis(left - 1, right, str + "(", result);
            if (right > 0 && left < right)
                this.generateParenthesis(left, right - 1, str + ")", result);
        }
    }
}
