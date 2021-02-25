using System;
using System.Collections.Generic;
using System.Text;

namespace DPProblemSets
{
    public class FibMemoization //Top-Down
    {

        private Dictionary<int, int> dic = new Dictionary<int, int>();

        public FibMemoization()
        {
            dic.Add(0, 0);
            dic.Add(1, 1);
        }
        
        //T(n) = O(n)
        //S(n) = O(n)
        public int Fib(int n)
        {
            if (dic.ContainsKey(n))
                return dic[n];

            dic[n] = Fib(n - 1) + Fib(n - 2);
            return dic[n];
        }
    }
}
