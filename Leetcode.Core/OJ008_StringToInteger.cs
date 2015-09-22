using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Implement atoi to convert a string to an integer.
     * 
     * 1. 字串为空或者全是空格，返回0； 
     * 2. 字串的前缀空格需要忽略掉；
     * 3. 忽略掉前缀空格后，遇到的第一个字符，如果是‘+’或‘－’号，继续往后读；如果是数字，则开始处理数字；如果不是前面的2种，返回0；
     * 4. 处理数字的过程中，如果之后的字符非数字，就停止转换，返回当前值；
     * 5. 在上述处理过程中，如果转换出的值超出了int型的范围，就返回int的最大值或最小值。
     */
    public class OJ008_StringToInteger
    {
        public int MyAtoi(string str)
        {
            str = str.Trim();
            if (str.Length < 1)
                return 0;

            int i = 0;
            long result = 0;
            bool isNegetive = false;

            if (str[i] == '+')
            {
                i++;
            }
            else if (str[i] == '-')
            {
                isNegetive = true;
                i++;
            }

            for (; i < str.Length; i++)
            {
                char c = str[i];
                if (c >= '0' && c <= '9')
                {
                    result = result * 10;
                    result = isNegetive ? result - (c - '0') : result + (c - '0');

                    if (result > int.MaxValue)
                        return int.MaxValue;
                    if (result < int.MinValue)
                        return int.MinValue;
                }
                else
                    break;
            }
            return (int)result;
        }
    }
}
