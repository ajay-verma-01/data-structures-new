using System;
using System.Collections.Generic;
using System.Text;

namespace DPProblemSets
{
    public class MaximumPathSum
    {
        public class Solution
        {
            //T(m,n) = O(mn)
            //S(m,n) = O(mn) // we can optimize it by using either two rows or two coloumns which is min(m,n)
            public int FindMinPathSum(int[][] grid)
            {
                int rows = grid.Length;
                int coloums = grid[0].Length;
                int[,] table = new int[rows, coloums];

                table[0, 0] = grid[0][0];
                for (int i = 1; i < rows; i++)
                {
                    table[i, 0] = table[i - 1, 0] + grid[i][0];
                }

                for (int j = 1; j < coloums; j++)
                {
                    table[0, j] = table[0, j - 1] + grid[0][j]; ;
                }

                for (int row = 1; row < rows; row++)
                {
                    for (int col = 1; col < coloums; col++)
                    {
                        table[row, col] = Math.Max(table[row, col - 1], table[row - 1, col]) + grid[row][col];
                    }
                }

                return table[rows - 1, coloums - 1];
            }
        }
    }
}
