using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsAlgo
{
    public class BubbleSort
    {
        public static void Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-i-1; j++)
                {
                    if (nums[j] > nums[j+1])
                        Swap(nums, j, j+1);
                }
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
