using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RecursionProblemSets
{

    /*
    40. Combination Sum II
       Medium

       Share
       Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.
       Each number in candidates may only be used once in the combination.
       Note: The solution set must not contain duplicate combinations.

       Example 1:
       Input: candidates = [10,1,2,7,6,1,5], target = 8
       Output: 
       [
       [1,1,6],
       [1,2,5],
       [1,7],
       [2,6]
       ]
    */

    /*Use Subsets 2 solution*/
    public class CombinationsSumII
    {
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            Helper(candidates, target, 0, new List<int>(), result);

            return result;
        }

        private static void Helper(int[] candidates, int target, int i, IList<int> slate, IList<IList<int>> result)
        {
            if (slate.Sum(x => x) > target)
                return;

            if (slate.Sum(x => x) == target)
            {
                result.Add(new List<int>(slate));
                return;
            }

            if (i == candidates.Length)
                return;

            Helper(candidates, target, i + 1, slate, result);

            slate.Add(candidates[i]);
            Helper(candidates, target, i + 1, slate, result);
            slate.RemoveAt(slate.Count - 1);
        }
    }
}
