using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblemSets
{
    /*
     77. Combinations
Medium
Given two integers n and k, return all possible combinations of k numbers out of 1 ... n.
You may return the answer in any order.
    
Example 1:

Input: n = 4, k = 2
Output:
[
  [2,4],
  [3,4],
  [2,3],
  [1,2],
  [1,3],
  [1,4],
]
     */
    public class Combinations
    {
        public  static IList<IList<int>> Combine(int n, int k)
        {
            
            var result = new List<IList<int>>();

            Helper(n, k, new List<int>(), result);


            int[] input = new int[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = i +1;
            }

            var result1 = new List<IList<int>>();

            Helper1(input, k, 0, new List<int>(), result1);

            return result;

        }

        private static void Helper(int n, int k, IList<int> slate, IList<IList<int>> result)
        {
            /*All subsets*/
            //if(0 == n)
            //{
            //    result.Add(new List<int>(slate));
            //    return;

            //}

            //Helper(n-1, slate, result);

            //slate.Add(n);
            //Helper(n-1, slate, result);
            //slate.RemoveAt(slate.Count - 1);


            

            if (slate.Count == k)
            {
                result.Add(new List<int>(slate));
                return;

            }

            if (n == 0)
                return;

            Helper(n - 1, k, slate, result);

            slate.Add(n);
            Helper(n - 1, k, slate, result);
            slate.RemoveAt(slate.Count - 1);
        }

        private static void Helper1(int[] input, int k, int i, IList<int> slate, IList<IList<int>> result)
        {
         
            if (slate.Count == k)
            {
                result.Add(new List<int>(slate));
                return;

            }

            if (i == input.Length)
                return;

            Helper1(input, k, i+1, slate, result);

            slate.Add(input[i]);
            Helper1(input, k, i+1, slate, result);
            slate.RemoveAt(slate.Count -1);
        }
    }
}
