using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    public class KthLargest
    {
        public static int FindKthLargestInUnsortedArray(int[] nums, int k)
        {
            KthLargestHelper(nums, 0, nums.Length - 1, nums.Length - k);
            return nums[nums.Length - k];
        }

        private static void KthLargestHelper(int[] nums, int start, int end, int index)
        {
            if (start == end)
                return;

            int pi = new Random().Next(start, end);

            int orange = start;
            Swap(nums, start, pi);

            for (int green = start +1; green <= end; green++)
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
                KthLargestHelper(nums, start, orange - 1, index);
            else
                KthLargestHelper(nums, orange + 1, end, index);
        }

        public static int[] QuickSort(int[] nums)
        {
            QuickHelper(nums, 0, nums.Length - 1);
            return nums;
        }

        private static void QuickHelper(int[] nums, int start, int end)
        {
            if (start >= end)
                return;

            int pivotIndex = new Random().Next(start, end); //pick random pivot index
            Swap(nums, start, pivotIndex); //swap pivot with start so that you can find the right place of it by waliking from start +1 to end;

            var orange = start;

            for (int green = start + 1; green <= end; green++)
            {
                if (nums[green] < nums[start])
                {
                    orange++;
                    Swap(nums, orange, green);
                }
            }

            Swap(nums, start, orange);

            QuickHelper(nums, start, orange - 1);
            QuickHelper(nums, orange + 1, end);
        }

        private static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];  
            nums[j] = temp;
        }
    }
}
