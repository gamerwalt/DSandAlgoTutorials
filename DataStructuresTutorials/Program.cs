using DataStructuresTutorials.AlgoExpert;
using DataStructuresTutorials.AlgoExpert.Easy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DataStructuresTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("************* FIND CLOSEST VALUE IN BST *****************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("");
            var root = new BST(10);
            root.left = new BST(5);
            root.left.left = new BST(2);
            root.left.left.left = new BST(1);
            root.left.right = new BST(5);
            root.right = new BST(15);
            root.right.left = new BST(13);
            root.right.left.right = new BST(14);
            root.right.right = new BST(22);

            var expected = 13;
            var found = root.FindClosestValueInBst(root, 12);
            Console.WriteLine($"Expected output: {expected}");
            Console.WriteLine($"Found ouput: {found}");


            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("************* TWO NUMBER SUM ********************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("");
            /** TwoNumberSum */
            int[] array = { -21, 301, 12, 4, 65, 56, 210, 356, 9, -47 };
            int targetSum = 164;
            var checker = TwoNumberSumClass.TwoNumberSum(array, targetSum);
            for (int i = 0; i < checker.Length; i++)
            {
                Console.WriteLine(checker[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*************SUBSEQUENCE OF AN ARRAY ********************");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("*********************************************************");

            /***Subsequence***/
            int[] firstArray = { 1, 1, 1, 1, 1 };
            int[] secondArray = { 1, 1, 1 };

            var validator = new ValidateArraySubsequence();
            Console.WriteLine(validator.isValideSubsequence(firstArray.ToList(), secondArray.ToList()));
            Console.WriteLine(validator.isSubSequence(firstArray.ToList(), secondArray.ToList()));
            /**End of subsequence**/

            //var input = 0;
            //Console.WriteLine("Reversing numbers*****************");
            //var reverser = new EasyProblems.ReverseInteger();
            //Console.WriteLine(reverser.ReverseInt(-123));
            //Console.WriteLine(reverser.ReverseInt(123));
            //Console.WriteLine("************************************");
            //Console.WriteLine("************************************");

            //input = 121;
            //var palindrome = new EasyProblems.PalindromeNumber();
            //var isPalindrome = palindrome.isPalindrome(121);
            //Console.WriteLine("Is " + input + " a palindrome? " + isPalindrome.ToString());

            //input = -121;
            //isPalindrome = palindrome.isPalindrome(-121);
            //Console.WriteLine("Is " + input + " a palindrome? " + isPalindrome.ToString());

            //input = 10;
            //isPalindrome = palindrome.isPalindrome(10);
            //Console.WriteLine("Is " + input + " a palindrome? " + isPalindrome.ToString());
        }

        public static bool isPalindromeNumber(int x)
        {
            if(x < 0)
            {
                return false;
            }

            int numDigits = (int)(Math.Floor(Math.Log10(x))) + 1;
            int msdMask = (int)Math.Pow(10, numDigits - 1);

            return true;
        }

        public static long reverse(int x)
        {
            long result = 0;
            long xRemaining = Math.Abs(x);
            while(xRemaining != 0)
            {
                result = result * 10 + xRemaining % 10;
                xRemaining /= 10;
            }

            return x < 0 ? -result : result;
        }

        public static void reverseQueue(Queue<int> queue)
        {
            Console.WriteLine("");
            Console.WriteLine("reversing queue");
            //the idea here I believe is to use a stack to remove the items from the queue then 
            //use the same stack to populate the queue
            var stack = new Stack<int>();
            while(queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while(stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            foreach (var item in queue)
            {
                Console.Write(item);
            }
        }
    }
}
