using System;
using System.Collections.Generic;
using System.Text;

namespace DPProblemSets
{
    public class ClimbingStairs
    {
        public int ClimbStairsRec(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;

            return ClimbStairsRec(n - 1) + ClimbStairsRec(n - 2);
        }

        public int ClimbStairs(int n)
        {
            int[] table = new int[3];

            table[1] = 1;
            table[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                table[i % 3] = table[(i - 1) % 3] + table[(i - 2) % 3];
            }

            return table[n % 3];
            
        }
    }
}
