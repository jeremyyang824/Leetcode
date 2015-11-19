using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
     * Note:
     * You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2. 
     * The number of elements initialized in nums1 and nums2 are m and n respectively.
     */
    public class OJ088_MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int ia = m - 1;
            int ib = n - 1;
            int icur = m + n - 1;

            while (ia >= 0 && ib >= 0)
            {
                nums1[icur] = nums1[ia] > nums2[ib] ? nums1[ia--] : nums2[ib--];
                icur--;
            }
            while (ib >= 0)
            {
                nums1[icur] = nums2[ib--];
                icur--;
            }
        }
    }
}
