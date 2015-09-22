using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Determine whether an integer is a palindrome. Do this without extra space.
     * 
     * Some hints:
     * Could negative integers be palindromes? (ie, -1)
     */
    public class OJ009_PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            if (x == 0)
                return true;

            int b = 1;
            while (x / b >= 10)
                b *= 10;

            while (x > 0)
            {
                int left = x / b;
                int right = x % 10;

                if (left != right)
                    return false;

                x = (x - (left * b) - right) / 10;
                b = b / 100;
            }

            return true;
        }
    }
}
