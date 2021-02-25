using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    public class MergeSort
    {

        public static void Sort(int[] nums)
        {
            MergeHelper(nums, 0, nums.Length - 1);


        }

        private static void MergeHelper(int[] nums, int start, int end)
        {
            if (start >= end)
                return;

            int mid = start + (end - start) / 2;

            MergeHelper(nums, start, mid);
            MergeHelper(nums, mid + 1, end);
            Merge(nums, start, mid, end);
        }

        private static void Merge(int[] nums, int start, int mid, int end)
        {
            int i = start; int j = mid +1;int[] tempArray = new int[nums.Length]; int tempIndex = start;
            while (i <= mid && j <= end)
            {
                if (nums[i] < nums[j])
                {
                    tempArray[tempIndex] = nums[i];
                    tempIndex++;
                    i++;
                }
                else if (nums[i] > nums[j])
                {
                    tempArray[tempIndex] = nums[j];
                    tempIndex++;
                    j++;
                }
                else
                {
                    tempArray[tempIndex] = nums[i];
                    tempIndex++;
                    tempArray[tempIndex] = nums[j];
                    tempIndex++;
                    i++;
                    j++;
                }
            }

            while (i <= mid)
            {
                tempArray[tempIndex] = nums[i];
                tempIndex++;
                i++;
            }

            while (j <= end)
            {
                tempArray[tempIndex] = nums[j];
                tempIndex++;
                j++;
            }

            for (int k = start; k < tempIndex; k++)
            {
                nums[k] = tempArray[k];
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
