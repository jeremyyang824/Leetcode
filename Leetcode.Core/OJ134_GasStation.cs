using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * There are N gas stations along a circular route, where the amount of gas at station i is gas[i].
     * You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from station i to its next station (i+1). 
     * You begin the journey with an empty tank at one of the gas stations.
     * Return the starting gas station's index if you can travel around the circuit once, otherwise return -1.
     */
    public class OJ134_GasStation
    {
        /*
         * 思路一：求循环数组的最大子序列问题
         * 我们用diff[i] = gas[i] - cost[i] 表示从当前站点出发，到下一个站点后剩余的油量
         * 题目就是需要找出这么一个点，从这个点出发，diff的累加值能达到峰值，如果车从这儿开都不能做到油箱不空，那么就回-1
         * 因此，这道题转化成了 求循环数组的最大子序列问题。
         * 
         */
        /*
         * 思路二：
         * 假设从站点 i 出发，到达站点 k 之前，依然能保证油箱里油没见底儿，从k 出发后，见底儿了。
         * 那么就说明 diff[i] + diff[i+1] + ... + diff[k] < 0，而除掉diff[k]以外，从diff[i]开始的累加都是 >= 0的。
         * 也就是说diff[i] 也是 >= 0的，这个时候我们还有必要从站点 i + 1 尝试吗？
         * 因此，当我们发现到达k 站点邮箱见底儿后，i 到 k 这些站点都不用作为出发点来试验了，肯定不满足条件，只需要从k+1站点尝试即可！
         * 我们模拟一下过程：
         * a. 最开始，站点0是始发站，假设车开出站点p后，油箱空了，假设sum1 = diff[0] +diff[1] + ... + diff[p]，可知sum1 < 0；
         * b. 根据上面的论述，我们将p+1作为始发站，开出q站后，油箱又空了，设sum2 = diff[p+1] +diff[p+2] + ... + diff[q]，可知sum2 < 0。
         * c. 将q+1作为始发站，假设一直开到了未循环的最末站，油箱没见底儿，设sum3 = diff[q+1] +diff[q+2] + ... + diff[size-1]，可知sum3 >= 0。
         */
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int total = 0, sum = 0, start = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                int diff = gas[i] - cost[i];
                total += diff;

                if (sum < 0)
                {
                    sum = diff;
                    start = i;
                }
                else
                {
                    sum += diff;
                }
            }
            return total < 0 ? -1 : start;
        }
    }
}
