using System;
using System.Collections.Generic;
using System.Text;

namespace DPProblemSets
{
    public class FibTabulation //BottomUp
    {
        //T(n) = O(n)
        //S(n) = O(n)
        public int Fib(int n)
        {
            int[] table = new int[n + 1];

            table[0] = 0;
            table[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                table[i] = table[i - 1] + table[i - 2];
            }

            return table[n];
        }

        //T(n) = O(n)
        //S(n) = O(1)
        public int FibOptimization(int n)
        {
            int[] table = new int[3];

            table[0] = 0;
            table[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                table[i % 3] = table[(i - 1) % 3] + table[(i - 2) % 3];

                //if (i % 3 == 0)
                //{
                //    table[0] = table[(i - 1) % 3] + table[(i - 2) % 3];
                //    //table[0] = table[1] + table[2];
                //}
                //else if (i % 3 == 1)
                //{
                //    table[1] = table[(i - 1) % 3] + table[(i - 2) % 3];
                //    //table[1] = table[0] + table[2];
                //}
                //else if (i % 3 == 2)
                //{
                //    table[2] = table[(i - 1) % 3] + table[(i - 2) % 3];
                //    //table[2] = table[0] + table[1];
                //}
            }

            return table[n % 3];
        }
    }
}
