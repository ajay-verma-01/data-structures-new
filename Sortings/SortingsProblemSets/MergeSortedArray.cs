using System;
using System.Collections.Generic;
using System.Text;

namespace SortingsProblemSets
{
    public class MergeSortedArray
    {
        public static void MergeSortedArrayWithoutAuxArrayByReplacingZero(int[] nums1, int m, int[] nums2, int n)
        {
            int index = m - 1;
            int i = m - n - 1, j = n - 1;
            while (i >=0 && j>=0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[index] = nums1[i];
                    i--;
                    index--;
                }
                else if (nums1[i] < nums2[j])
                {
                    nums1[index] = nums2[j];
                    j--;
                    index--;
                }
                else
                {
                    nums1[index] = nums1[i];
                    index--;

                    nums1[index] = nums2[j];
                    index--;

                    i--;
                    j--;

                }
            }

            while (j >= 0)
            {
                nums1[index] = nums2[j];
                j--;
                index--;
            }
        }

        public static void MergeSortedArrayWithoutAuxArrayByReplacingZero1(int[] nums1, int m, int[] nums2, int n)
        {
            int k = m - 1;
            int i = m - n - 1, j = n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                    k--;
                }
                else if (nums1[i] < nums2[j])
                {
                    nums1[k] = nums2[j];
                    j--;
                    k--;
                }
                else
                {
                    nums1[k] = nums1[i];
                    k--;

                    nums1[k] = nums2[j];
                    k--;

                    i--;
                    j--;

                }
            }

            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }
    }
}
