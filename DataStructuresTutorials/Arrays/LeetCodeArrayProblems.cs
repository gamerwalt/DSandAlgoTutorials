using System;
using System.Collections.Generic;

namespace DataStructuresTutorials.Arrays
{
    public class LeetCodeArrayProblems
    {
        public static int RemoveDuplicates(int[] array)
        {
            #region comments
            /**
            Given a sorted array nums, remove the duplicates in-place such that each element appears only once and returns the new length.
            Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

            Example 1:
            Input: nums = [1,1,2]
            Output: 2, nums = [1,2]
            Explanation: Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. It doesn't matter what you leave beyond the returned length.
            
            Example 2:
            Input: nums = [0,0,1,1,1,2,2,3,3,4]
            Output: 5, nums = [0,1,2,3,4]
            Explanation: Your function should return length = 5, with the first five elements of nums being modified to 0, 1, 2, 3, and 4 respectively. It doesn't matter what values are set beyond the returned length.
            **/
            #endregion

            if (array.Length == 0) return 0;

            int current = 0;
            for(int i = 1; i<array.Length; i++)
            {
                if(array[i] != array[current])
                {
                    current++;
                    array[current] = array[i];
                }
            }

            return current + 1;
        }

        public static int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            var current = 0;
            for(int index = 0; index<nums.Length; index++)
            {
                if(nums[index] != val)
                {
                    nums[current] = nums[index];
                    current++;
                }
            }

            return current;
        }

        public static int SearchInsert(int[] nums, int target)
        {
            var index = 0;
            for (index = 0; index < nums.Length; index++)
            {
                if (target == nums[index])
                {
                    return index;
                }
                else if (target < nums[index])
                {
                    return index;
                }
            }

            return index;
        }

        public static int MaximumSubArray(int[] nums)
        {
            if (nums.Length == 0) return 0;

            var currentStreak = nums[0];
            var globalStreak = currentStreak;
            for(int index = 1; index<nums.Length; index++)
            {
                if(nums[index] > nums[index] + currentStreak)
                {
                    currentStreak = nums[index];
                }
                else
                {
                    currentStreak += nums[index];
                }

                globalStreak = Math.Max(globalStreak, currentStreak);
            }

            return globalStreak;
        }

        public static int[] EasyPlusOne(int[] digits)
        {
            for(int i = digits.Length - 1; i>=0; i--)
            {
                if(digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            digits = new int[digits.Length + 1];
            digits[0] = 1;
            return digits;
        }

        public static void MergeSortArray3(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums1.Length == 0) return;
            if (nums2.Length == 0) return;

            int p1 = m - 1;
            int p2 = n - 1;
            int p = m + n - 1;

            while((p1>=0) && (p2>=0))
            {
                nums1[p--] = (nums1[p] < nums2[p2]) ? nums2[p2--] : nums1[p1--];
            }

            System.Array.Copy(nums2, 0, nums1, 0, p2 + 1);
        }

        public static void MergeSortArray2(int[] nums1, int m, int[] nums2, int n)
        {
            System.Array.Copy(nums2, 0, nums1, m, n);
            System.Array.Sort(nums1);
        }

        public static void MergeSortArray(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums1 == null) return;
            if (nums2 == null) return;

            if (nums2.Length == 0) return;

            for(int indexNums1 = m; indexNums1 < nums1.Length; indexNums1++)
            {
                nums1[indexNums1] = nums2[indexNums1 - m];
            }

            //then we merge sort here
            MergeSort(nums1);
        }

        private static void MergeSort(int[] nums1)
        {
            if (nums1.Length < 2)
                return;

            var length = nums1.Length;
            var middle = length / 2;
            var left = new int[middle];
            var right = new int[length - middle];

            for(int i = 0; i<middle; i++)
                left[i] = nums1[i];

            for(int i = middle; i<length; i++)
                right[i-middle] = nums1[i];

            MergeSort(left);
            MergeSort(right);

            Merge(left, right, nums1);
        }

        private static void Merge(int[] left, int[] right, int[] results)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while(leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] <= right[rightIndex])
                    results[resultIndex++] = left[leftIndex++];
                else
                    results[resultIndex++] = right[rightIndex++];
            }

            while(leftIndex < left.Length)
                results[resultIndex++] = left[leftIndex++];

            while (rightIndex < right.Length)
                results[resultIndex++] = right[rightIndex++];
        }
    }
}
