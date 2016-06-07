﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * There are N children standing in a line. Each child is assigned a rating value.
     * You are giving candies to these children subjected to the following requirements:
     * Each child must have at least one candy.
     * Children with a higher rating get more candies than their neighbors.
     * What is the minimum candies you must give?
     */
    public class OJ135_Candy
    {
        /*
         * 思路：
         * 先从左到右扫描一遍，使得右边比左边得分高的小朋友糖果数比左边多。
         * 再从右到左扫描一遍，使得左边比右边得分高的小朋友糖果数比右边多。
         */
        public int Candy(int[] ratings)
        {
            int size = ratings.Length;
            if (size == 0)
                return -1;
            if (size == 1)
                return 1;

            int[] cans = new int[size];
            cans[0] = 1;

            //正向扫描一遍，如果右边的rating比左边高，那么右边的糖果数就比左边多一个，否则只给一个糖果
            for (int i = 1; i < size; i++)
            {
                if (ratings[i] > ratings[i - 1])
                    cans[i] = cans[i - 1] + 1;
                else
                    cans[i] = 1;
            }

            //反向扫描一遍，如果左边的rating比右边高，并且左边的糖果数比右边少，那么左边的糖果数应比右边多一 
            for (int i = size - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1] && cans[i] <= cans[i + 1])
                    cans[i] = cans[i + 1] + 1;
            }

            int rent = 0;
            for (int i = 0; i < size; i++)
            {
                rent += cans[i];
            }
            return rent;
        }
    }
}
