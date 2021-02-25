using System;
using System.Collections.Generic;

namespace SortingsProblemSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Two Sum----------");
            Console.WriteLine(TwoSum.IsTwoSumExistsSortedArray(new[] { 4, 1, 5, 6, 8, 3 }, 7));
            Console.WriteLine(TwoSum.IsTwoSumExistsSortedArray(new[] { 4, 1, 5, 6, 8, 3 }, 15));
            Console.WriteLine(TwoSum.IsTwoSumExistsUnsortedArray(new[] { 4, 1, 5, 6, 8, 3 }, 7));
            Console.WriteLine(TwoSum.IsTwoSumExistsUnsortedArray(new[] { 4, 1, 5, 6, 8, 3 }, 15));

            Console.WriteLine("-----------Two sum indices----------");
            var result = TwoSum.TwoSumIndicesUnsortedArray(new[] { 4, 1, 5, 6, 8, 3 }, 7);
            foreach (var item in result)
            {
                Console.Write(item + ",");
            }


            Console.WriteLine("-----------Meeting Room-----------");
            Console.WriteLine(MeetingRoom.FindIfAPersonCanAttendAllTheMeeting(new List<int[]>() { new[]{ 0, 30 }, new[] { 5, 10 },new[] { 15, 20 } }));
            Console.WriteLine(MeetingRoom.FindIfAPersonCanAttendAllTheMeeting(new List<int[]>() { new[] { 0, 5 }, new[] { 5, 10 }, new[] { 15, 20 } }));

            Console.WriteLine(MeetingRoom.FindHowManyMeetingRooms(new List<int[]>() { new[] { 0, 30 }, new[] { 5, 10 }, new[] { 15, 20 } }));
            Console.WriteLine(MeetingRoom.FindHowManyMeetingRooms(new List<int[]>() { new[] { 0, 5 }, new[] { 5, 10 }, new[] { 15, 20 } }));


            Console.WriteLine("-----------Binary Search-----------");
            Console.WriteLine(IntersectionTwoArray.BinarySaerchRec(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 5, 6));
            Console.WriteLine(IntersectionTwoArray.BinarySaerchRec(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 5, 7));

            Console.WriteLine(IntersectionTwoArray.BinarySaerchIt(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 5, 6));
            Console.WriteLine(IntersectionTwoArray.BinarySaerchIt(new int[] { 1, 2, 3, 4, 5, 6 }, 0, 5, 7));

            Console.WriteLine("-----------Intersection-----------");
            var listA = IntersectionTwoArray.IntersectionBinarySearch(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 6 });
            foreach (var item in listA)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine("");
            var listB = IntersectionTwoArray.IntersectionTwoPinters(new int[] { 1, 2, 6, 9, 11, 12, 13, 16, 20 }, new int[] { 1, 2, 3, 4, 5, 6, 20 });
            foreach (var item in listB)
            {
                Console.Write(item + ",");
            }


            Console.WriteLine("");
            var listC = IntersectionTwoArray.UnionSortedArray(new int[] { 1, 2, 6, 9, 11, 12, 13, 16, 20 }, new int[] { 1, 2, 3, 4, 5, 6, 20, 21 });
            foreach (var item in listC)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("");
            var listd = IntersectionTwoArray.IntersectionHandlingDuplicates(new int[] { 1, 2,2, 6, 9, 11,11, 12, 13, 16, 20 }, new int[] { 1, 2, 3, 4, 5,5, 6, 11, 11, 20, 21 });
            foreach (var item in listd)
            {
                Console.Write(item + ",");
            }


            Console.WriteLine("");
            int[] arr1 = new int[] { 1,2,3,0,0,0};
            int[] arr2 = new int[] { 2,5,6 };
            MergeSortedArray.MergeSortedArrayWithoutAuxArrayByReplacingZero(arr1, arr1.Length, arr2, arr2.Length);
            foreach (var item in arr1)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("");
            int[] arr3 = new int[] { 2, 4, 6, 0, 0, 0 };
            int[] arr4 = new int[] { 1,3,5 };
            MergeSortedArray.MergeSortedArrayWithoutAuxArrayByReplacingZero(arr3, arr3.Length, arr4, arr4.Length);
            foreach (var item in arr3)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("");
            int[] arr5 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] arr6 = new int[] { 2, 5, 6 };
            MergeSortedArray.MergeSortedArrayWithoutAuxArrayByReplacingZero(arr5, arr5.Length, arr6, arr6.Length);
            foreach (var item in arr5)
            {
                Console.Write(item + ",");
            }


            Console.WriteLine("\n-----------------------KthLarget-------------------------");
            int[] nums = new int[] { 8,7,1,3,4,5,10,9,2,6 };
            Console.WriteLine("-----------------------QuickSort-------------------------");
            KthLargest.QuickSort(nums);
            foreach (var item in nums)
            {
                Console.Write(item + ",");
            }


            int[] nums1 = new int[] { 3, 2, 1, 5, 6, 4 };
            Console.WriteLine("\n-------------KthLarget----------3,2,1,5,6,4-------------------------");
            Console.WriteLine(KthLargest.FindKthLargestInUnsortedArray(nums1, 2));

            int[] nums2 = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            Console.WriteLine("\n-------------KthLarget----------3,2,3,1,2,4,5,5,6-------------------------");
            Console.WriteLine(KthLargest.FindKthLargestInUnsortedArray(nums2, 4));


            int[] nums3 = new int[] { 3, 2, 1, 5, 6, 4 };
            Console.WriteLine("\n-------------KthSmallest----------3,2,1,5,6,4-------------------------");
            Console.WriteLine(KthSmallest.KthSmallestInUnsortedArray(nums3, 2));

            int[] nums4 = new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            Console.WriteLine("\n-------------KthSmallest----------3,2,3,1,2,4,5,5,6-------------------------");
            Console.WriteLine(KthSmallest.KthSmallestInUnsortedArray(nums4, 4));

            int[] nums5 = new int[] { 3, 2, 1, 5, 6, 4, 7 };
            Console.WriteLine("\n-------------Median----------3, 2, 1, 5, 6, 4, 7-------------------------");
            Console.WriteLine(MedianElement.FindMedianInUnsortedArray(nums5));

            int[] nums6 = new int[] { 3, 2, 1, 8, 5, 6, 4, 7 };
            Console.WriteLine("\n-------------Median----------3, 2, 1, 8, 5, 6, 4, 7 -------------------------");
            Console.WriteLine(MedianElement.FindMedianInUnsortedArray(nums6));

            int[,] nums7 = { { 1, 3 }, { -2, 2 } };

            for (int i = 0; i < nums7.Length; i++)
            {
                //Console.WriteLine(nums[i, 0]);
            }
            Console.WriteLine("\n-------------KClosest Points-----------------------------------");
            //Console.WriteLine(KClosestPoint.KClosest(nums7, 1));


            Console.WriteLine("\n-------------TopKElements  Input: nums = [1,1,1,2,2,3], k = 2-----------------------------------");

            int[] nums8 = { 1, 1, 1, 2, 2, 3 };
            var res = TopKFrequentElement.TopKFrequent(nums8, 2);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.WriteLine("\n-------------TopKElements  -----------------------------------");

            int[] bums9 = { 1, 1, 1, 2, 2, 3,3,3,3, 5,4, 6,6,6,6,6 };
            var res1 = TopKFrequentElement.TopKFrequent(bums9, 3);

            for (int i = 0; i < res1.Length; i++)
            {
                Console.WriteLine(res1[i]);
            }


            Console.WriteLine("\n-------------GroupNumbersEvenOdd  ---{8,4,9,5,2,9,5,7,10 };--------------------------------");

            int[] nums10 = {8,4,9,5,2,9,5,7,10 };
            var res2 = GroupNumbersEvenOdd.GroupNumbers(nums10);

            for (int i = 0; i < res2.Length; i++)
            {
                Console.Write(res2[i] + ",");
            }

            Console.WriteLine("\n-------------GroupNumbersEvenOdd  ---{2,3,5 };--------------------------------");

            int[] nums11 = { 2, 3, 5};
            var res3 = GroupNumbersEvenOdd.GroupNumbers(nums11);

            for (int i = 0; i < res3.Length; i++)
            {
                Console.Write(res3[i] + ",");
            }

            Console.WriteLine("\n-------------GroupNumbersEvenOdd  ---{8,4,9,5,2,9,5,7,10 };--------------------------------");

            int[] nums12 = { 8, 4, 9, 5, 2, 9, 5, 7, 10 };
            var res4 = GroupNumbersEvenOdd.GroupNumbers1(nums12);

            for (int i = 0; i < res4.Length; i++)
            {
                Console.Write(res4[i] + ",");
            }


            Console.WriteLine("\n-------------Merge Sort  ---{8,4,9,5,2,9,5,7,10, 20,11,11,1,2 };--------------------------------");

            int[] nums13 = { 8, 4, 9, 5, 2, 9, 5, 7, 10, 20, 11, 11, 1, 2 };
            MergeSort.Sort(nums13);

            for (int i = 0; i < nums13.Length; i++)
            {
                Console.Write(nums13[i] + ",");
            }

            Console.WriteLine("\n-------------DutchNationalFlag---G,B, G, G ,R, G , R B--------------------------------");

            char[] chars = { 'G', 'B', 'G', 'G', 'R', 'G', 'R', 'B' };
            DutchNationalFlag.Sort(chars);

            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i] + ",");
            }

            Console.ReadKey();

        }
    }
}
