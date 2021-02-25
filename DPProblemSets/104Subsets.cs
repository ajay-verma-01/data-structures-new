using System;
using System.Collections.Generic;
using System.Text;

namespace DPProblemSets
{
    public class Subsets
    {
        public int nCk(int n, int k)
        {

            //C(n,k) = n! / k!(n-k)!

            if (k == 0)
                return 1;
            if (k == n)
                return 1;

            return nCk(n - 1, k) + nCk(n - 1, k - 1);
        }

        //T(n) = O(n*k)
        //S(n) = O(n*k)
        public int nCkDP(int n, int k)
        {

            //C(n,k) = n! / k!(n-k)!
            int[,] table = new int[n + 1, k + 1];

            if (k == 0 ||k == n)
                return 1;

            for (int i = 0; i <= n; i++)
            {
                table[i,0] = 1;
            }

            for (int j = 0; j <= k; j++)
            {
                table[j, j] = 1;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= Math.Min(j,k); j++)
                {
                    table[i, j] = table[i - 1, j] + table[i - 1, j - 1];
                }
            }

            return table[n, k];
        }
    }
}
