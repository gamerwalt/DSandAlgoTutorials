using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.AlgoExpert.Easy
{
    public class BranchSums
    {
        public static List<int> GetBranchSums(BST tree)
        {
            List<int> sums = new List<int>();

            GetBranchSums(tree, sums, 0);

            return sums;
        }

        private static void GetBranchSums(BST tree, List<int> sums, int summedUpValue)
        {
            if (tree == null) return;

            var newSummedUpValue = summedUpValue + tree.value;

            if(tree.left == null && tree.right == null)
            {
                sums.Add(newSummedUpValue);
                return;
            }

            GetBranchSums(tree.left, sums, newSummedUpValue);
            GetBranchSums(tree.right, sums, newSummedUpValue);
        }
    }
}
