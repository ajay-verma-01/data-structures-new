using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsAlgo
{
    public class InsertionSort
    {
        public static void Sort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                var key = nums[i];
                var j = i - 1;

                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }

                nums[j + 1] = key;
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
