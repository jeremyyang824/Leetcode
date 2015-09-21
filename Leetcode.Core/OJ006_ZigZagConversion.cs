using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
     * 
     * P   A   H   N
     * A P L S I I G
     * Y   I   R
     * 
     * And then read line by line: "PAHNAPLSIIGYIR"
     * Write the code that will take a string and make this conversion given a number of rows:
     * string convert(string text, int nRows);
     * convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR".
     */
    public class OJ006_ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length < 1)
                return s;

            string[] resultArr = new string[numRows];
            int i = 0;
            while (i < s.Length)
            {
                for (int j = 0; j < numRows && i < s.Length; j++)
                    resultArr[j] += s[i++];

                for (int j = numRows - 2; j > 0 && i < s.Length; j--)
                    resultArr[j] += s[i++];
            }

            string result = "";
            for (int k = 0; k < numRows; k++)
                result += resultArr[k];

            return result;
        }
    }
}
