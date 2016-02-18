using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Say you have an array for which the ith element is the price of a given stock on day i.
     * If you were only permitted to complete at most one transaction 
     * (ie, buy one and sell one share of the stock), design an algorithm to find the maximum profit.
     */
    public class OJ121_BestTimeToBuyAndSellStock
    {
        /*
         * 第一种方法：
         *  从左往右求下标0到 k - 1 的最小值MIN 从右往左求 下标k到n -1 的最大值MAX，对于每个k都有一个MAX - MIN的值，最后求这个值的最大值即可。
         * 
         * 第二种方法：
         *  令b[j] = a[j + 1] - a[j]，
         *  那么a[j] - a[i] = (a[i+1]-a[i])+(a[i+2]-a[i+1])+...+(a[j]-a[i-1])
         *                  = b[i] +b[i+1]+ ...+ b[j - 1]，
         *  即将问题转化成求一个数组子序列的最大值。
         *  
         * 第三种方法：
         *  找到一个最低点low，并在low之后找一个最高点high，计算差值ans；
         *  如果low点之后有更低的点，则以新的最低点为low，往后找新的最高点high，计算新的差值；
         *  （在一个连续序列中不可能包含新旧两个low，此时差值必然小于由新的low开始的序列）
         *  如果新的差值大于原本的差值ans，则更新ans。
         */
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;

            int low = prices[0];
            int ans = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < low)
                    low = prices[i];
                else if (prices[i] - low > ans)
                    ans = prices[i] - low;
            }
            return ans;
        }
    }
}
