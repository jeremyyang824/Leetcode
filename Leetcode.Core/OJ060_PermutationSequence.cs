using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * The set [1,2,3,…,n] contains a total of n! unique permutations.
     * By listing and labeling all of the permutations in order,
     * We get the following sequence (ie, for n = 3):
     * 1. "123"
     * 2. "132"
     * 3. "213"
     * 4. "231"
     * 5. "312"
     * 6. "321" 
     * Given n and k, return the kth permutation sequence.
     * Note: Given n will be between 1 and 9 inclusive.
     */
    public class OJ060_PermutationSequence
    {
        /*
         * 对于第1个数字a1：有n种可能，每种出现 n!/n 次；
         * 若a1确定，对于第2个数字a2：有n-1种可能，每种出现 (n-1)!/(n-1)次；
         * ...
         * 最终k可以表示为 k=A1(n-1)!+A2(n-2)!+...+An （其中Ak代表该数为剩余数字中第Ak小的数字）。
         */
        public string GetPermutation(int n, int k)
        {
            int[] nums = new int[n];
            int pCount = 1;
            for (int i = 0; i < n; ++i)
            {
                nums[i] = i + 1;
                pCount *= (i + 1);  //阶乘
            }

            k--; //从0开始计算
            string result = "";
            for (int i = 0; i < n; i++)
            {
                pCount = pCount / (n - i);
                int selected = k / pCount;
                result += nums[selected].ToString();

                for (int j = selected; j < n - i - 1; j++)
                    nums[j] = nums[j + 1];  //可选范围缩小一个
                k = k % pCount; 
            }
            return result;
        }
    }
}
