using System;
using System.Collections.Generic;
using System.Text;

namespace DPProblemSets
{
    public class UniquePathII
    {
        //T(m,n) = O(mn)
        //S(m,n) = O(mn) // we can optimize it by using either two rows or two coloumns which is min(m,n)
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {

            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;
            //edge case
            if (obstacleGrid[0][0] == 1)
            {
                return 0;
            }
            //base cases
            obstacleGrid[0][0] = 1;
            for (int i = 1; i < m; i++)
            {
                if (obstacleGrid[i][0] == 0 && obstacleGrid[i - 1][0] == 1)
                    obstacleGrid[i][0] = 1;
                else
                    obstacleGrid[i][0] = 0;
            }

            for (int j = 1; j < n; j++)
            {
                if (obstacleGrid[0][j] == 0 && obstacleGrid[0][j - 1] == 1)
                    obstacleGrid[0][j] = 1;
                else
                    obstacleGrid[0][j] = 0;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 0)
                        obstacleGrid[i][j] = obstacleGrid[i][j - 1] + obstacleGrid[i - 1][j];
                    else
                        obstacleGrid[i][j] = 0;
                }
            }

            return obstacleGrid[m - 1][n - 1];
        }
    }
}
