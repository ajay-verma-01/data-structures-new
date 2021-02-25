using System;

namespace SortingsAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] nums = new int[] { 6, 7, 8, 9, 2, 4, 1,3,5 };
            Console.WriteLine("--------Bubble Sort------");
            BubbleSort.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            
            
            int[] nums1 = new int[] { 6, 7, 8, 9, 2, 4, 1, 3, 5 };
            Console.WriteLine("--------Selection Sort ------");
            SelectionSort.Sort(nums1);
            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine(nums1[i]);
            }

            int[] nums2 = new int[] { 6, 7, 8, 9, 2, 4, 1, 3, 5 };
            Console.WriteLine("--------Insertion Sort ------");
            InsertionSort.Sort(nums2);
            for (int i = 0; i < nums2.Length; i++)
            {
                Console.WriteLine(nums2[i]);
            }


            int[] nums3 = new int[] { 9, 7, 8, 6, 4, 5, 3, 2, 1 };
            Console.WriteLine("--------Merge Sort ------");
            MergeSort.Sort(nums3);
            for (int i = 0; i < nums3.Length; i++)
            {
                Console.WriteLine(nums3[i]);
            }

            int[] nums4 = new int[] { 9, 7, 8, 6, 4, 5, 3, 2, 1 };
            Console.WriteLine("--------Quick Sort ------");
            QuickSort.Sort(nums4);
            for (int i = 0; i < nums4.Length; i++)
            {
                Console.WriteLine(nums4[i]);
            }
            Console.ReadKey();
        }

    }
}
