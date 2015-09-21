using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * There are two sorted arrays nums1 and nums2 of size m and n respectively. 
     * Find the median of the two sorted arrays. 
     * The overall run time complexity should be O(log (m+n)).
     */
    public class OJ004_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n = nums1.Length, m = nums2.Length;
            int[] resultArr = new int[n + m];
            int x = 0, y = 0;
            for (int i = 0; i < resultArr.Length; i++)
            {
                if (x >= n)
                    resultArr[i] = nums2[y++];
                else if (y >= m)
                    resultArr[i] = nums1[x++];

                else
                {
                    if (nums1[x] <= nums2[y])
                    {
                        resultArr[i] = nums1[x++];
                    }
                    else
                    {
                        resultArr[i] = nums2[y++];
                    }
                }
            }

            return (n + m) % 2 != 0 ? resultArr[(n + m) / 2] : ((resultArr[(n + m - 1) / 2] + resultArr[(n + m) / 2]) / 2.0);
        }
    }
}
