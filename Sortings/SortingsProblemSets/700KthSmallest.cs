using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    public class KthSmallest
    {
        public static int KthSmallestInUnsortedArray(int[] nums, int k)
        {
            KthSmallestHelper(nums, 0, nums.Length - 1, k-1);
            return nums[k-1];
        }

        private static void KthSmallestHelper(int[] nums, int start, int end, int index)
        {
            if (start == end)
                return;

            int pi = new Random().Next(start, end);

            int orange = start;
            Swap(nums, start, pi);

            for (int green = start + 1; green <= end; green++)
            {
                if (nums[green] < nums[start])
                {
                    orange++;
                    Swap(nums, green, orange);
                }
            }

            Swap(nums, start, orange);

            if (index == orange)
                return;
            else if (index < orange)
                KthSmallestHelper(nums, start, orange - 1, index);
            else
                KthSmallestHelper(nums, orange + 1, end, index);
        }

        private static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
