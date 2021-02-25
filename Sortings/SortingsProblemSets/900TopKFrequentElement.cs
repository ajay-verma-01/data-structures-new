using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SortingsProblemSets
{
    public class TopKFrequentElement
    {
        /*
         Given a non-empty array of integers, return the k most frequent elements.

        Example 1:

        Input: nums = [1,1,1,2,2,3], k = 2
        Output: [1,2]
        Example 2:

        Input: nums = [1], k = 1
        Output: [1]
         
         */
        public static int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i])) 
                    dic[nums[i]]++; 
                else 
                    dic.Add(nums[i], 1);
            }

            int[] arr = new int[dic.Count];
            int it = 0;
            foreach (var item in dic)
            {
                arr[it++] = item.Value;
            }

            TopKHelper(arr, 0, arr.Length - 1, arr.Length - k);

            int[] result = new int[k];
            int count = 0;
            for (int i = arr.Length-1; i >= arr.Length - k; i--)
            {
                result[count] = dic.FirstOrDefault(x => x.Value == arr[i]).Key;
                dic.Remove(result[count]);
                count++;
            }

            return result;
        }

        private static void TopKHelper(int[] arr, int start, int end, int index)
        {
            if (start == end)
                return;

            var pi = new Random().Next(start, end);
            Swap(arr, start, pi);

            int orange = start;

            for (int green = start +1; green <= end; green++)
            {
                if (arr[green] < arr[start])
                {
                    orange++;
                    Swap(arr, orange, green);
                }
            }

            Swap(arr, orange, start);

            if (orange == index)
                return;
            else if (index < orange)
                TopKHelper(arr, start, orange - 1, index);
            else
                TopKHelper(arr, orange + 1, end, index);
        }

        private static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
