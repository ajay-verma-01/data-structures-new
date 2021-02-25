using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    public class MedianElement
    {
        public static double FindMedianInUnsortedArray(int[] nums)
        {
            if (nums.Length % 2 == 0)
            {
                var m = nums.Length / 2;
                FindMedianHelper(nums, 0, nums.Length - 1, (nums.Length / 2) -1);
                return (double)(nums[m] + nums[m - 1]) / 2;
               
            }
            else
            {
                FindMedianHelper(nums, 0, nums.Length - 1, nums.Length / 2);
                return nums[nums.Length / 2];
            }
            
        }

        private static void FindMedianHelper(int[] nums, int start, int end, int index)
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
                FindMedianHelper(nums, start, orange - 1, index);
            else
                FindMedianHelper(nums, orange + 1, end, index);
        }

        private static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
