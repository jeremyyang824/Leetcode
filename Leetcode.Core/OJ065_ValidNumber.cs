using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Validate if a given string is numeric.
     * Some examples:
     * "0" => true
     * " 0.1 " => true
     * "abc" => false
     * "1 a" => false
     * "2e10" => true
     * Note: It is intended for the problem statement to be ambiguous. You should gather all requirements up front before implementing one.
     */
    public class OJ065_ValidNumber
    {
        public enum InputType
        {
            INVALID,    // 0
            SPACE,      // 1
            SIGN,       // 2
            DIGIT,      // 3
            DOT,        // 4
            EXPONENT,   // 5
        };

        private int[,] transitionTable = new int[,]
        {
            { -1,  0,  3,  1,  2, -1 },     // next states for state 0
            { -1,  8, -1,  1,  4,  5 },     // next states for state 1
            { -1, -1, -1,  4, -1, -1 },     // next states for state 2
            { -1, -1, -1,  1,  2, -1 },     // next states for state 3
            { -1,  8, -1,  4, -1,  5 },     // next states for state 4
            { -1, -1,  6,  7, -1, -1 },     // next states for state 5
            { -1, -1, -1,  7, -1, -1 },     // next states for state 6
            { -1,  8, -1,  7, -1, -1 },     // next states for state 7
            { -1,  8, -1, -1, -1, -1 },     // next states for state 8
        };

        public bool IsNumber(string s)
        {
            int state = 0;
            char[] sArr = s.ToCharArray();
            for (int i = 0; i < sArr.Length; i++)
            {
                char c = sArr[i];

                InputType inputType = InputType.INVALID;

                if (Char.IsWhiteSpace(c))
                    inputType = InputType.SPACE;
                else if (c == '+' || c == '-')
                    inputType = InputType.SIGN;
                else if (Char.IsDigit(c))
                    inputType = InputType.DIGIT;
                else if (c == '.')
                    inputType = InputType.DOT;
                else if (c == 'e' || c == 'E')
                    inputType = InputType.EXPONENT;

                state = transitionTable[state, (int)inputType];

                if (state == -1)
                    return false;
            }

            return state == 1 || state == 4 || state == 7 || state == 8;
        }
    }
}
