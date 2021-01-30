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

        public static int SearchInsert2(int[] nums, int target)
        {
            if (nums == null) return 0;
            if (nums.Length == 0) return 0;

            int pivot;
            int left = 0;
            int right = nums.Length - 1;
            while(left <= right)
            {
                pivot = left + (right - left) / 2;
                if (nums[pivot] == target) return pivot;
                if (target < nums[pivot])
                    right = pivot - 1;
                else
                    left = pivot + 1;
            }

            return left;
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

            var firstPointer = m - 1; //last index of the first array that is initialized
            var secondPointer = n - 1; //last index of the second array
            var currentPointer = m + n - 1; //last index of the first array
            while((firstPointer >= 0) && (secondPointer >=0))
            {
                if(nums1[firstPointer] < nums2[secondPointer])
                {
                    nums1[currentPointer] = nums2[secondPointer];
                    secondPointer--;
                }
                else
                {
                    nums1[currentPointer] = nums1[firstPointer];
                    firstPointer--;
                }

                currentPointer--;
            }

            System.Array.Copy(nums2, 0, nums1, 0, secondPointer + 1);
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

        //Pascal Triangle V2
        public static IList<int> EasyPascalTriangleGetRow(int rowIndex)
        {
            #region Findings
            //Example
            /*
            NOTE:   1 will always be the first and last numbers
                    If we give 3, we return an array or list of integers with 4 numbers.
            Example 1: rowIndex = 1, return        [1, 1]           2 numbers (1 + 1)
            Example 0: rowIndex = 2, return       [1, 2, 1]         3 numbers (2 + 1)
            Example 1: rowIndex = 3, return      [1, 3, 3, 1]       4 numbers (3 + 1)
            Example 2: rowIndex = 4, return    [1, 4, 6, 4, 1]      5 numbers (4 + 1)
            Example 3: rowIndex = 5, return  [1, 5, 10, 10, 5, 1]   6 numbers (5 + 1) //We know we have to loop x number of times

            First pattern:  if we give 3, we know that we will return 4 numbers with first and last = 1 and 2nd and 2nd to last equal to the actual row number
                            however, what comes between?
            Second Pattern: we add the first and last 1(s) and loop in the middle
                            Loop number of times here for 
                            if rowIndex = 1, loop zero times
                            if rowIndex = 2, loop once,
                            if rowIndex = 3, loop twice
            */
            #endregion

            int[] row = new int[rowIndex + 1];
            row[rowIndex] = 1;

            
            return row;
        }

        private static int GetResult(int counter)
        {
            if (counter <= 1) return 1;

            return GetResult(counter -1) + GetResult(counter - 1);
        }

        public static IList<IList<int>> EasyPascalTriangle(int numRows)
        {
            IList<IList<int>> listOfRows = new List<IList<int>>();
            if (numRows == 0) return listOfRows;

            listOfRows.Add(new List<int>() { 1 });

            for(int i = 1; i<numRows; i++)
            {
                var previousList = listOfRows[i - 1];
                var newRow = new List<int>();

                newRow.Add(1);

                for(int j = 1; j<previousList.Count; j++)
                {
                    newRow.Add(GetSumOfPreviousIndices(previousList, j));
                }

                newRow.Add(1);

                listOfRows.Add(newRow);
            }

            return listOfRows;
        }

        private static int GetSumOfPreviousIndices(IList<int> previousList, int j)
        {
            return previousList[j] + previousList[j - 1];
        }

        public static int MaxProfit(int[] prices)
        {
            /*
            Say you have an array for which the ith element is the price of a given stock on day i.
            If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
            Note that you cannot sell a stock before you buy one.

            Example 1:
            Input: [7,1,5,3,6,4]
            Output: 5
            Explanation: Buy on day 2(price = 1) and sell on day 5(price = 6), profit = 6 - 1 = 5.
                       Not 7 - 1 = 6, as selling price needs to be larger than buying price.

            Example 2:
            Input:[7,6,4,3,1]
            Output: 0
            Explanation: In this case, no transaction is done, i.e.max profit = 0.
            */
            int maxProfit = 0;

            if (prices.Length == 0) return maxProfit;

            int minBuyingPrice = int.MaxValue;
            
            for(int i = 0; i<prices.Length; i++)
            {
                if(minBuyingPrice > prices[i])
                {
                    minBuyingPrice = prices[i];
                }
                else if(prices[i] - minBuyingPrice > maxProfit)
                {
                    maxProfit = prices[i] - minBuyingPrice;
                }
            }

            return maxProfit;
        }

        public static int MaxProfit2(int[] prices)
        {
            /*
            Say you have an array prices for which the ith element is the price of a given stock on day i.
            Design an algorithm to find the maximum profit. You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).
            Note: You may not engage in multiple transactions at the same time (i.e., you must sell the stock before you buy again).

            Example 1:
            Input: [7,1,5,3,6,4]
            Output: 7
            Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit = 5-1 = 4.
                         Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 = 3.
            Example 2:
            Input: [1,2,3,4,5]
            Output: 4
            Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit = 5-1 = 4.
                         Note that you cannot buy on day 1, buy on day 2 and sell them later, as you are
                         engaging multiple transactions at the same time. You must sell before buying again.
            Example 3:
            Input: [7,6,4,3,1]
            Output: 0
            Explanation: In this case, no transaction is done, i.e. max profit = 0.
            */
            int currentProfit = 0;
            int globalMaxProfit = 0;

            if (prices.Length == 0) return currentProfit;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i])
                {
                    globalMaxProfit += prices[i + 1] - prices[i];
                }
            }

            return globalMaxProfit;
        }

        public static IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            IList<string> list = new List<string>();

            if(lower == upper && nums.Length > 0)
            {
                return list;
            }
            else if(lower == upper && nums.Length == 0)
            {
                list.Add($"{upper}");
                return list;
            }

            for(int i = 0; i<nums.Length-1; i++)
            {
                if(Math.Abs(nums[i+1] - nums[i]) != 1)
                {
                    var num1 = nums[i] + 1;
                    var num2 = nums[i + 1] - 1;
                    if(num1 != num2)
                    {
                        list.Add($"{num1}->{num2}");
                    }
                    else
                    {
                        list.Add($"{num1}");
                    }
                }
            }
            
            if(nums.Length != 0)
            {
                if (Math.Abs(upper) - nums[nums.Length - 1] != 1)
                {
                    list.Add($"{nums[nums.Length - 1] + 1}->{upper}");
                }
            }
            else
            {
                list.Add($"{lower}->{upper}");
            }
            

            return list;
        }
    }
}
