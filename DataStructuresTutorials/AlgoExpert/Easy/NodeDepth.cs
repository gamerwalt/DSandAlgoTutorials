using System;
using System.Collections.Generic;
using System.Text;


namespace DataStructuresTutorials.AlgoExpert.Easy
{
    public class NodeDepth
    {
        public static int NodeDepths(BST tree)
        {
            int sumOfDepths = 0;
            Stack<Level> stack = new Stack<Level>();
            stack.Push(new Level(tree, 0));
            while(stack.Count > 0)
            {
                Level top = stack.Pop();

                var node = top.root;
                int depth = top.depth;
                if (node == null) continue;

                sumOfDepths += depth;
                stack.Push(new Level(node.left, depth + 1));
                stack.Push(new Level(node.right, depth + 1));
            }

            return sumOfDepths;
        }
    }

    public class Level
    {
        public BST root;
        public int depth;

        public Level(BST root, int depth)
        {
            this.root = root;
            this.depth = depth;
        }
    }

}
