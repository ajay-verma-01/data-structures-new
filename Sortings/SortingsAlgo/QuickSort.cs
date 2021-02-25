using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SortingsAlgo
{
    public class QuickSort
    {
        public static void Sort(int[] nums)
        {
            SortHelper(nums, 0, nums.Length - 1);
        }

        private static void SortHelper(int[] nums, int start, int end)
        {
            if (start >= end)
                return;
            int pi = Partition(nums, start, end);
            SortHelper(nums, start, pi - 1);
            SortHelper(nums, pi + 1, end);
        }

        private static int Partition(int[] nums, int start, int end)
        {
            int pivot = nums[end];//

            int storeIndix = start - 1; //Index of smaller element

            for (int j = start; j < end; j++)
            {
                if (nums[j] < pivot)
                {
                    storeIndix++;
                    Swap(nums, storeIndix, j);
                }
            }

            Swap(nums, storeIndix + 1, end);

            return storeIndix + 1;

        }

        public static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
            //SemaphoreSlim n = new SemaphoreSlim(1, 5);
        }
    }
}
