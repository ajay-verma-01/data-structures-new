using System;
using System.Collections.Generic;
using System.Text;

namespace DPProblemSets
{
    public class MinCostClimbingStairs
    {
        //T(n) = O(n)
        //S(n) = O(n)
        public int FindMinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;
            int[] table = new int[n + 2];
            table[0] = 0;
            table[1] = cost[0];

            Array.Resize(ref cost, cost.Length + 1);

            for (int i = 2; i < n + 2 ; i++)
            {
                table[i] = cost[i-1] + Math.Min(table[i - 1], table[i - 2]);
            }

            return table[n + 1];
        }
    }
}
