using System;
using System.Collections.Generic;
using System.Text;

namespace January_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var strs = new string[] { "flower", "flow", "flight" };
            var result = LongestCommonPrefix(strs);
            Console.WriteLine(result);
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            StringBuilder value = new StringBuilder();

            for(int i = 0; i<strs.Length; i++)
            {
                var currentString = strs[i];
                for(int j = 0; j < currentString.Length; j++)
                {
                    if (strs[i][j] == currentString[j])
                    {
                        value.Append(currentString[j]);
                    }
                    else
                    {
                        return value.ToString();
                    }                    
                }
            }

            return value.ToString();
        }

        /// <summary>
        /// Sample: nums = [2, 7, 11, 15], target = 9, should return [0 ,1]
        /// Sample: nums = [3, 2, 4], target = 6, should return [1, 2]
        /// Sample: nums = [3, 3], target = 6, should return [0, 1]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] returnValue = new int[2];

            Dictionary<int, int> hash = new Dictionary<int, int>();

            for(int i = 0; i<=nums.Length - 1; i++)
            {
                var remainder = target - nums[i];
                
                if(hash.ContainsKey(remainder))
                {
                    returnValue[0] = hash.GetValueOrDefault(remainder);
                    returnValue[1] = i;
                    break;
                }
                
                hash.Add(nums[i], i);
            }

            return returnValue;
        }

        /// <summary>
        /// Sample: 123 becomes 321
        /// </summary>
        /// <param name="number"></param>
        public static int ReverseInteger(int number)
        {
            bool isNegative = false;
            if (number < 0)
            {
                isNegative = true;
                number *= -1;
            }

            long result = 0;

            while(number > 0)
            {
                var remainder = number % 10;
                number = number / 10;

                result = (result * 10) + remainder;
            }

            if (result >= int.MaxValue) return 0;

            return isNegative ? (int)(result * -1) : (int)(result);
        }

        /// <summary>
        /// number = 121, returns true, number 123 returns false;
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindromeNumber(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                Console.WriteLine($"REverted Number: {revertedNumber}");
                x /= 10;
                Console.WriteLine($"X becomes: {x}");
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            Console.WriteLine($"x now is {x}");
            Console.WriteLine($"reverted number is now: {revertedNumber}");
            return x == revertedNumber || x == revertedNumber / 10;

        }

        public static int RomanNumerialToInt(string romanNumeral)
        {
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("M", 1000);
            dictionary.Add("D", 500);
            dictionary.Add("C", 100);
            dictionary.Add("L", 50);
            dictionary.Add("X", 10);
            dictionary.Add("V", 5);
            dictionary.Add("I", 1);

            int sum = 0;

            for(int i = 0; i<romanNumeral.Length; i++)
            {
                string currentKey = romanNumeral[i].ToString();
                string nextKey;
                int nextValue = 0;
                int currentValue = dictionary[currentKey];

                if ((i + 1) >= romanNumeral.Length) {
                    nextKey = "";
                }
                else
                {
                    nextKey = romanNumeral[i + 1].ToString();
                    nextValue = dictionary[nextKey];
                }

                if (nextValue > currentValue)
                {
                    sum += (nextValue - currentValue);
                    i++;
                }
                else
                {
                    sum += currentValue;
                }                
            }

            return sum;
        }
    }
}
