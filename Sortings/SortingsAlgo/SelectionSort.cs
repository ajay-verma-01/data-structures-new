using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsAlgo
{
    public class SelectionSort
    {
        public static void Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                int min_index = i;
                for (int j = i +1; j < nums.Length; j++)
                {
                    if (nums[min_index] > nums[j])
                        min_index = j;
                }

                Swap(nums, i, min_index);
            }
        }

        public static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
