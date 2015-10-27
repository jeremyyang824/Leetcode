using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leetcode.Core
{
    /*
     * You are given an n x n 2D matrix representing an image.
     * Rotate the image by 90 degrees (clockwise).
     * Follow up:
     * Could you do this in-place?
     */
    public class OJ048_RotateImage
    {
        /*
         * 由外圈向内圈旋转，每个元素的旋转涉及4个相关元素（含自身）
         */ 
        public void Rotate(int[,] matrix)
        {
            int temp = 0;
            int len = (int)Math.Sqrt(matrix.Length);
            for (int i = 0; i < len / 2; i++)
            {
                for (int j = i; j < len - 1 - i; j++)
                {
                    temp = matrix[i, j];    //top
                    matrix[i, j] = matrix[len - 1 - j, i];                      //left -> top
                    matrix[len - 1 - j, i] = matrix[len - 1 - i, len - 1 - j];  //bottom -> left
                    matrix[len - 1 - i, len - 1 - j] = matrix[j, len - 1 - i];  //right -> bottom
                    matrix[j, len - 1 - i] = temp;                              //top -> right
                }
            }
        }

        /*
         * TODO：先沿副对角线翻转一次，再沿水平线翻转一次。或者先沿水平线翻转一次，再沿主对角线翻转一次。
         */ 
    }
}
