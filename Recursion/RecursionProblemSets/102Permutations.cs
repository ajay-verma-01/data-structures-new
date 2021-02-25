using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionProblemSets
{

    /*
     Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
Example 2:

Input: nums = [0,1]
Output: [[0,1],[1,0]]
Example 3:

Input: nums = [1]
Output: [[1]]
     */
    public class Permutations
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            var slate = new List<int>();
            Helper(nums, 0, slate, result);

            return result;
        }

        private static void Helper(int[] nums, int i, IList<int> slate, IList<IList<int>>  result)
        {
            if (i == nums.Length)
            {
                result.Add(new List<int>(slate));
                return;
            }

            for (int pick = i; pick < nums.Length; pick++)
            {
                Swap(nums, pick, i);
                slate.Add(nums[i]);
                Helper(nums, i + 1, slate, result);
                slate.RemoveAt(slate.Count - 1);
                Swap(nums, pick, i);
            }
        }

        private static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
