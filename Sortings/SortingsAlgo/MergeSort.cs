using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsAlgo
{
    public class MergeSort
    {
        public static void Sort(int[] nums)
        {
            SortHelper(nums, 0, nums.Length - 1);
        }

        private static void SortHelper(int[] nums, int start, int end)
        {
            if (start >= end)
                return;
            int mid = (start + end) / 2;
            SortHelper(nums, start, mid);
            SortHelper(nums, mid + 1, end);
            Merge(nums, start, mid, end);
        }

        private static void Merge(int[] nums, int start, int mid, int end)
        {
            int i = start; int j = mid + 1; int[] temp = new int[nums.Length]; int index = start;

            while (i <= mid && j <= end)
            {
                if (nums[i] < nums[j])
                {
                    temp[index] = nums[i];
                    i++;
                }
                else
                {
                    temp[index] = nums[j];
                    j++;
                }
                index++;
            }

            while (i <= mid)
            {
                temp[index] = nums[i];
                i++;
                index++;
            }

            while (j <= end)
            {
                temp[index] = nums[j];
                j++;
                index++;
            }


            for (int k = start; k < index; k++)
            {
                nums[k] = temp[k];
            }
        }
    }
}
