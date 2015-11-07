using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Implement int sqrt(int x).
     * Compute and return the square root of x.
     */
    public class OJ069_SqrtX
    {
        /*
         * (x/2 + 1) ^ 2 > x
         */
        //public int MySqrt(int x)
        //{
        //    if (x < 0)
        //        return -1;
        //    if (x == 0)
        //        return 0;

        //    int low = 1;
        //    int high = x / 2 + 1;
        //    int mid;
        //    while (low <= high)
        //    {
        //        mid = (high + low) / 2;
        //        long tmp = mid * mid;

        //        if (tmp == x)
        //            return mid;
        //        else if (tmp < x)
        //            low = mid + 1;
        //        else
        //            high = mid - 1;
        //    }
        //    return high;    //high == low - 1
        //}

        /*
         * 牛顿法求平方根
         * Xi+1= (Xi + n/Xi) / 2
         */
        public int MySqrt(int x)
        {
            if (x == 0) 
                return 0;
            double last = 0;
            double res = 1;
            while (last != res)
            {
                last = res;
                res = (last + x / last) / 2;
            }
            return (int)res;
        }
    }
}
