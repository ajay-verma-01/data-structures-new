using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    /*
     Group the numbers
You are given an integer array arr of size n. Group and rearrange them (in-place) into evens and odds in such a way that group of all even integers appears on the left side and group of all odd integers appears on the right side. 



Example

Input: [1, 2, 3, 4]



Output: [4, 2, 1, 3]



Order does not matter. Other valid solutions are: 

[2, 4, 1, 3]

[2, 4, 3, 1]

[4, 2, 3, 1]
    {8,4,9,5,2,9,5,7,10 };
     */
    public class GroupNumbersEvenOdd
    {

        public static int[] GroupNumbers(int[] nums)
        {
            int i = 0; int j = nums.Length - 1;

            while (i < j)
            {
                if (nums[i] % 2 != 0)
                {
                    while (nums[j] % 2 != 0 && j > i)
                        j--;
                    Swap(nums, i, j);
                    j--;
                    
                }
                i++;
            }

            return nums;
        }

        public static int[] GroupNumbers1(int[] nums)
        {
            int i = 0; int evenPtr = 0;

            while (i < nums.Length)
            {
                if (nums[i] % 2 == 0)
                {
                    Swap(nums, evenPtr, i);
                    evenPtr++;
                }

                i++;
            }
           
            return nums;
        }

        private static void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        static int[] solve(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                while (arr[left] % 2 == 0 && left < right)
                    left++;

                while (arr[right] % 2 == 1 && left < right)
                    right--;

                if (left < right)
                {
                    var temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }

            }

            return arr;
        }
    }
}
