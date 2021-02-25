using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    public class TwoSum
    {
        public static bool IsTwoSumExistsSortedArray(int[] arr, int target)
        {
            Array.Sort(arr);

            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                if (arr[i] + arr[j] == target)
                    return true;
                else if (arr[i] + arr[j] < target)
                    i++;
                else
                    j--;
            }

          
            return false;
        }

        public static List<int> TwoSumIndicesSortedArray(int[] arr, int target)
        {
            Array.Sort(arr);
            var list = new List<int>();
            int i = 0;
            int j = arr.Length - 1;

            while (i < j)
            {
                if (arr[i] + arr[j] == target)
                {
                    list.Add(i);
                    list.Add(j);
                }
                else if (arr[i] + arr[j] < target)
                    i++;
                else
                    j--;
            }


            return list;
        }

        public static bool IsTwoSumExistsUnsortedArray(int[] arr, int target)
        {
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (hs.Contains(target - arr[i]))
                    return true;
                else
                    hs.Add(arr[i]);
            }

            return false;
        }

        public static List<int> TwoSumIndicesUnsortedArray(int[] arr, int target)
        {
            Dictionary<int, int> hs = new Dictionary<int, int>();
            var list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (hs.ContainsKey(target - arr[i]))
                {
                    list.Add(hs[target - arr[i]]);
                    list.Add(i);

                }
                else
                    hs.Add(arr[i], i);
            }

            return list;
        }
    }
}
