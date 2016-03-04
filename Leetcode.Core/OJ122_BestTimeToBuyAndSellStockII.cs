using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Say you have an array for which the ith element is the price of a given stock on day i.
     * Design an algorithm to find the maximum profit. You may complete as many transactions as you like 
     * (ie, buy one and sell one share of the stock multiple times). 
     * However, you may not engage in multiple transactions at the same time (ie, you must sell the stock before you buy again).
     */
    public class OJ122_BestTimeToBuyAndSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;

            int low = prices[0];
            int ans = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < prices[i - 1])
                {
                    ans += prices[i - 1] - low;
                    low = prices[i];
                }
                else if (i == prices.Length - 1)
                {
                    ans += prices[i] - low;
                }
            }
            return ans;
        }
    }
}
