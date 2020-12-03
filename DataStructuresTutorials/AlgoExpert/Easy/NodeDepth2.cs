using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.AlgoExpert.Easy
{
    public class NodeDepth2
    {
        public static int GetNodeDepth(BST tree)
        {
            if (tree == null) return 0;

            return GetNodeDepth(tree, 0);
        }

        private static int GetNodeDepth(BST tree, int nodeDepth)
        {
            if (tree == null)
            {
                return 0;
            }
            if(tree.left == null && tree.right == null)
            {
                return nodeDepth;
            }

            return nodeDepth + GetNodeDepth(tree.left, nodeDepth + 1) + GetNodeDepth(tree.right, nodeDepth + 1);
        }
    }
}
