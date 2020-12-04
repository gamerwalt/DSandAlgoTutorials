using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.AlgoExpert.Easy
{
    public class BranchSums2
    {
        public static List<int> GetBranchSums(BST tree)
        {
            var sums = new List<int>();

            GetBranchSums(tree, sums, 0);

            return sums;
        }

        private static void GetBranchSums(BST tree, List<int> sums, int runningSummation)
        {
            if (tree == null)
            {
                return;
            }

            runningSummation = runningSummation + tree.value;

            Console.WriteLine("****************************");
            Console.WriteLine($"Running summation is: {runningSummation}");
            Console.WriteLine($"Current node is : {tree.value}");
            Console.WriteLine("****************************");

            if (tree.left == null && tree.right == null)
            {
                sums.Add(runningSummation);
                return;
            }

            GetBranchSums(tree.left, sums, runningSummation);
            GetBranchSums(tree.right, sums, runningSummation);
        }
    }
}
