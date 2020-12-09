using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.AVLTreesTutorials
{
    public class AVLTree
    {
        private AVLNode root;

        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        private AVLNode Insert(AVLNode node, int value)
        {
            if(node == null)
            {
                node = new AVLNode(value);
                return node;
            }

            if(value < node.Value)
            {
                node.LeftChild = Insert(node.LeftChild, value);
            }
            else
            {
                node.RightChild = Insert(node.RightChild, value);
            }

            return node;
        }

        private class AVLNode
        {
            public int Value;
            public AVLNode RightChild;
            public AVLNode LeftChild;

            public AVLNode(int value)
            {
                Value = value;
            }
        }
    }
}
