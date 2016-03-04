using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Say you have an array for which the ith element is the price of a given stock on day i.
     * Design an algorithm to find the maximum profit. You may complete at most two transactions.
     * Note:
     * You may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
     */
    public class OJ123_BestTimeToBuyAndSellStockIII
    {
        /*
         * 思路：把prices[] 分成两部分prices[0...m] 和 prices[m...length]，分别计算在这两部分内做交易的做大收益，复杂度：O(n^2)
         * 
         * DP改进：
         *  1.正向扫描0~n-1, 计算子序列[0,...,i]上的最大利润，用一个数组保存下来，那么时间是O(n)
         *  2.逆向扫描n-1~0, 计算子序列[i,...,n-1]上的最大利润，并保存
         *  3.
         */
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;

            int[] maxProfit1 = new int[prices.Length];
            int[] maxProfit2 = new int[prices.Length];

            int low = prices[0];
            int ans = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < low)
                    low = prices[i];
                else if (prices[i] - low > ans)
                    ans = prices[i] - low;

                maxProfit1[i] = ans;
            }

            int high = prices[prices.Length - 1];
            ans = 0;
            for (int i = prices.Length - 2; i >= 0; i--)
            {
                if (prices[i] > high)
                    high = prices[i];
                else if (high - prices[i] > ans)
                    ans = high - prices[i];

                maxProfit2[i] = ans;
            }

            int total = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                int tmp = maxProfit1[i] + maxProfit2[i];
                if (total < tmp)
                    total = tmp;
            }
            return total;
        }
    }
}
