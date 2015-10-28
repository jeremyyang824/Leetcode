using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Implement pow(x, n).
     */
    public class OJ050_Pow
    {
        public double MyPow(double x, int n)
        {
            if (n < 0)
                return 1d / pow(x, n * -1);
            else
                return pow(x, n);
        }

        private double pow(double x, int n)
        {
            if (n == 0)
                return 1;

            double temp = this.pow(x, n / 2);

            if (n % 2 == 0)
                return temp * temp;
            else
                return temp * temp * x;
        }
    }
}
