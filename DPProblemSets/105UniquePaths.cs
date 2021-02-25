using System;
using System.Collections.Generic;
using System.Text;

namespace DPProblemSets
{
    /*
        62. Unique Paths
Medium


A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).

The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

How many possible unique paths are there?
     */
    public class UniquePaths
    {

        //T(m,n) = O(mn)
        //S(m,n) = O(mn) // we can optimize it by using either two rows or two coloumns which is min(m,n)
        public int FindUniquePaths(int m, int n)
        {
            int[,] table = new int[m, n];

            //base cases

            for (int i = 0; i < m; i++)
            {
                table[i, 0] = 1;
            }

            for (int j = 0; j < n; j++)
            {
                table[0, j] = 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    table[i, j] = table[i, j-1] + table[i - 1, j];
                }
            }

            return table[m-1, n-1];
        }
    }
}
