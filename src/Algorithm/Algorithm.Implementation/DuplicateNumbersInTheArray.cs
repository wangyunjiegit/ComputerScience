﻿using System;

namespace Algorithm.Implementation
{
    /// <summary>
    /// 数组中重复的数字
    /// 在一个长度为 n 的数组里的所有数字都在 0 到 n-1 的范围内。数组中某些数字是重复的，但不知道有几个数字是重复的，也不知道每个数字重复几次。请找出数组中任意一个重复的数字。
    /// Input:
    /// {2, 3, 1, 0, 2, 5}
    /// Output:
    /// 2
    /// </summary>
    public class DuplicateNumbersInTheArray
    {
        /// <summary>
        /// 解题
        /// </summary>
        public int? ProblemSolve(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return arr[i];
                    }
                }
            }

            return null;
        }
    }
}
