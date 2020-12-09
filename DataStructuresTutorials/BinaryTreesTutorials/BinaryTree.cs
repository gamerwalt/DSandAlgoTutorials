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
                if (value >= current.value)
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

        public bool AreSiblings(int first, int second)
        {
            if(!Contains(root, first) || !Contains(root, second))
            {
                return false;
            }

            return AreSiblings(root, first, second);
        }

        private bool AreSiblings(Node root, int first, int second)
        {
            if (root == null) return false;

            var areSiblings = false;

            if(root.leftChild != null && root.rightChild != null)
            {
                areSiblings = (root.leftChild.value == first && root.rightChild.value == second) || (root.rightChild.value == first && root.leftChild.value == second);
            }

            return areSiblings || AreSiblings(root.leftChild, first, second) || AreSiblings(root.rightChild, first, second);
        }

        public bool Contains(int value)
        {
            return Contains(root, value);
        }

        private bool Contains(Node node, int value)
        {
            if (node == null) return false;

            if (node.value == value) return true;

            return Contains(node.leftChild, value) || Contains(node.rightChild, value);
        }

        public int Max()
        {
            return Max(root);
        }

        private int Max(Node root)
        {
            if (root.leftChild == null && root.rightChild == null) return root.value;

            return Math.Max(Max(root.leftChild), Max(root.rightChild));
        }

        public int Min()
        {
            return Min(root);
        }

        private int Min(Node root)
        {
            if (root.leftChild == null && root.rightChild == null) return root.value;

            return Math.Min(Min(root.leftChild), Min(root.rightChild));
        }

        public int CountLeaves()
        {
            return CountLeaves(root);
        }

        private int CountLeaves(Node node)
        {
            if (IsLeaf(node)) return 1;

            return CountLeaves(node.leftChild) + CountLeaves(node.rightChild);
        }

        public int GetSize()
        {
            return GetSize(root);
        }

        private int GetSize(Node node)
        {
            if (node == null) return 0;

            if (IsLeaf(node)) return 1;

            return 1 + GetSize(node.leftChild) + GetSize(node.rightChild);
        }

        private bool IsLeaf(Node node)
        {
            return node.leftChild == null && node.rightChild == null;
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

        //Height = 1 + max(height(L), height(R))
        public int GetHeightOfTree()
        {
            return GetHeightOfNode(root);
        }

        private int GetHeightOfNode(Node root)
        {
            if (root == null) return -1;
            if (root.leftChild == null && root.rightChild == null) return 0;

            return 1 + Math.Max(GetHeightOfNode(root.leftChild), GetHeightOfNode(root.rightChild));
        }

        public bool Equals(BinaryTree tree)
        {
            if (tree == null) return false;

            return Equals(root, tree.root);
        }

        private bool Equals(Node first, Node second)
        {
            if (first == null && second == null) return true;

            if(first != null && second != null)
            {
                return first.value == second.value && Equals(first.leftChild, second.leftChild) && Equals(first.rightChild, second.rightChild);
            }

            return false;
        }

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySearchTree(Node root, int minValue, int maxValue)
        {
            if (root == null) return true;

            if (root.value > maxValue || root.value < int.MinValue) return false;

            return IsBinarySearchTree(root.leftChild, minValue, root.value - 1)
                && IsBinarySearchTree(root.rightChild, root.value + 1, maxValue);
        }

        public void PrintNodesFromDistanceFromRoot(int distance)
        {
            PrintNodesFromDistanceFromRoot(root, distance);
        }

        private void PrintNodesFromDistanceFromRoot(Node root, int distance)
        {
            if (root == null || root == null && distance != 0) return;

            if(distance == 0)
            {
                Console.WriteLine(root.value);
                return;
            }            

            PrintNodesFromDistanceFromRoot(root.leftChild, distance - 1);
            PrintNodesFromDistanceFromRoot(root.rightChild, distance - 1);
        }

        public void TraverseLevelOrder()
        {
            for(int i = 0; i<=GetHeightOfTree(); i++)
            {
                PrintNodesFromDistanceFromRoot(i);
            }
        }
    }
}
