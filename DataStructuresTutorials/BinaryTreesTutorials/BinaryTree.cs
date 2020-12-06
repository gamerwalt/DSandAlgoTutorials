using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.BinaryTreesTutorials
{
    public class BinaryTree
    {
        private class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value = value;
            }

            public override string ToString()
            {
                return $"Value: = {value}";
            }
        }

        private Node root;
        public void Insert(int value)
        {
            var node = new Node(value);

            if (root == null)
            {
                root = node;
                return;
            }

            var current = root;
            while (current != null)
            {
                if (value > current.value)
                {
                    if (current.rightChild == null)
                    {
                        current.rightChild = node;
                        break;
                    }
                    current = current.rightChild;
                }
                else if (value < current.value)
                {
                    if (current.leftChild == null)
                    {
                        current.leftChild = node;
                        break;
                    }
                    current = current.leftChild;
                }
            }
        }

        public bool Find(int value)
        {
            var current = root;
            while(current != null)
            {
                if(value > current.value)
                {
                    current = current.rightChild;
                }
                else if(value < current.value)
                {
                    current = current.leftChild;
                }
                else if(current.value == value)
                {
                    return true;
                }
            }

            return false;
        }

        public void TraversePreorder()
        {
            TraversePreorder(root);
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }

        private void TraversePostOrder(Node root)
        {
            if (root == null) return;

            TraversePostOrder(root.leftChild);
            TraversePostOrder(root.rightChild);
            Console.WriteLine(root.value);
        }

        private void TraverseInOrder(Node root)
        {
            if (root == null) return;

            TraverseInOrder(root.leftChild);
            Console.WriteLine(root.value);
            TraverseInOrder(root.rightChild);
        }

        private void TraversePreorder(Node root)
        {
            if (root == null) return;

            Console.WriteLine(root.value);
            TraversePreorder(root.leftChild);
            TraversePreorder(root.rightChild);
        }
    }
}
