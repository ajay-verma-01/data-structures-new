using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblemSets
{
    /*
        78. Subsets
Medium

4990

104

Add to List

Share
Given an integer array nums, return all possible subsets (the power set).

The solution set must not contain duplicate subsets.

 

Example 1:

Input: nums = [1,2,3]
Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
Example 2:

Input: nums = [0]
Output: [[],[0]]
     */
    public class Subsets
    {
        public static IList<IList<int>> FindSubsets(int[] nums)
        {
            var result = new List<IList<int>>();
            var slate = new List<int>();
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

            Helper(nums, i + 1, slate, result);

            slate.Add(nums[i]);
            Helper(nums, i + 1, slate, result);
            slate.RemoveAt(slate.Count -1);
        }
    }
}
