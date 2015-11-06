using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given two binary strings, return their sum (also a binary string).
     * For example,
     * a = "11"
     * b = "1"
     * Return "100".
     */
    public class OJ067_AddBinary
    {
        public string AddBinary(string a, string b)
        {
            if (b.Length > a.Length)
            {
                string temp = a;
                a = b;
                b = temp;
            }

            char[] aArr = a.ToCharArray();
            int aLen = aArr.Length;

            char[] bArr = b.ToCharArray();
            int bLen = bArr.Length;

            Stack<int> result = new Stack<int>();
            int carry = 0;
            for (int i = 0; i < bLen; i++)
            {
                int va = aArr[aLen - i - 1] == '1' ? 1 : 0;
                int vb = bArr[bLen - i - 1] == '1' ? 1 : 0;

                int sum = va + vb + carry;
                carry = sum / 2;
                result.Push(sum % 2);
            }

            for (int j = bLen; j < aLen; j++)
            {
                int va = aArr[aLen - j - 1] == '1' ? 1 : 0;
                int sum = va + carry;

                carry = sum / 2;
                result.Push(sum % 2);
            }

            if (carry > 0)
                result.Push(carry);

            StringBuilder sb = new StringBuilder();
            while (result.Count > 0)
                sb.Append(result.Pop().ToString());

            return sb.ToString();
        }
    }
}
