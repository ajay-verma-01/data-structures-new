using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    public class IntersectionTwoArray
    {

        //both are of same size, O(m+n) if n is constant O(m)
        public static List<int> IntersectionTwoPinters(int[] arr1, int[] arr2)
        {
            var list = new List<int>();

            //for (int i = 0, j = 0; i < arr1.Length && j < arr2.Length;)
            //{
            //    if (arr1[i] == arr2[j])
            //    {
            //        list.Add(arr1[i]);
            //        i++;
            //        j++;
            //    }
            //    else if (arr1[i] < arr2[j])
            //        i++;
            //    else
            //        j++;
            //}
            //return list;
            int i = 0; int j = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] == arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] < arr2[j])
                    i++;
                else
                    j++;
            }
            return list;
        }

        internal static List<int> IntersectionHandlingDuplicates(int[] arr1, int[] arr2)
        {
            var list = new List<int>();

            int i = 0; int j = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] == arr2[j])
                {
                    if (list.Count > 0 && list[list.Count - 1] == arr1[i])
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        list.Add(arr1[i]);
                        i++;
                        j++;
                    }
                   
                }
                else if (arr1[i] < arr2[j])
                    i++;
                else
                    j++;
            }
            return list;
        }

        public static List<int> UnionSortedArray(int[] arr1, int[] arr2)
        {
            var list = new List<int>();

            int i = 0; int j = 0;
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] == arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] < arr2[j])
                {
                    list.Add(arr1[i]);
                    i++;
                }
                else
                {
                    list.Add(arr2[j]);
                    j++;
                }
            }

            while (i < arr1.Length)
            {
                list.Add(arr1[i]);
                i++;
            }

            while (j < arr2.Length)
            {
                list.Add(arr2[j]);
                j++;
            }
            return list;
        }


        //If one of the array size if constant or very less in comparision to other O(n logm) if n is constant logm
        public static List<int> IntersectionBinarySearch(int[] arr1, int[] arr2)
        {
            var list = new List<int>();
            

            for (int i = 0; i < arr1.Length; i++)
            {
                if (BinarySaerchIt(arr2, 0, arr2.Length - 1, arr1[i]))
                    list.Add(arr1[i]);
            }

            return list;
        }

        public static bool BinarySaerchRec(int[] arr, int start, int end, int key)
        {
            if (start <= end)
            {
                var mid = start + end / 2;
                if (arr[mid] == key)
                    return true;
                else if (arr[mid] > key)
                    return BinarySaerchRec(arr, start, mid - 1, key);
                else
                    return BinarySaerchRec(arr, mid + 1, end, key);

            }
            return false;
        }

     
        public static bool BinarySaerchIt(int[] arr, int start, int end, int key)
        {
            while (start <= end)
            {
                var mid = (start + end) / 2;
                if (arr[mid] == key)
                    return true;
                else if (key < arr[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }

            return false;
        }
    }
}
