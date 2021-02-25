using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblemSets
{
    /*
     90. Subsets II
Medium

2131

94

Add to List

Share
Given a collection of integers that might contain duplicates, nums, return all possible subsets (the power set).

Note: The solution set must not contain duplicate subsets.

Example:

Input: [1,2,2]
Output:
[
  [2],
  [1],
  [1,2,2],
  [2,2],
  [1,2],
  []
]
     */
    public class SubsetsII
    {
        public static IList<IList<int>> FindSubsets(int[] nums)
        {
            var result = new List<IList<int>>();
            var slate = new List<int>();
            Array.Sort(nums);
            Helper(nums, 0, slate, result);
            return result;
        }

        public static void Helper(int[] nums, int i, IList<int> slate, IList<IList<int>> result)
        {
            if (i == nums.Length)
            {
                result.Add(new List<int>(slate));
                return;
            }

            var count = 0;
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                    break;
                count++;
            }

            Helper(nums, i + count, slate, result);

            for (int c = 1; c <= count; c++)
            {
                slate.Add(nums[i]);
                Helper(nums, i + count, slate, result);
            }

            for (int c = 0; c < count; c++)
            {
                slate.RemoveAt(slate.Count - 1);
            }
        }
    }
}
