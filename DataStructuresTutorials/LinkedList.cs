using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class LinkedList
    {
        private Node First;
        private Node Last;

        public void AddFirst(int value)
        {
            var node = new Node(value);

            if(First == null)
            {
                First = node;
                Last = First;
                return;
            }

            node.Next = First;
            First = node;
        }

        public void AddLast(int value)
        {
            var node = new Node(value);

            if(First == null)
            {
                First = node;
                Last = First;
                return;
            }

            if(Last == First)
            {
                Last = node;
                First.Next = Last;
                return;
            }

            Last.Next = node;
            Last = node;

        }

        public string Print()
        {
            var node = First;
            StringBuilder sb = new StringBuilder();
            int counter = 0;

            while(node != null)
            {
                counter++;
                if(counter == 1)
                {
                    sb.Append(node.Value);
                }
                else
                {
                    sb.Append(", " + node.Value);
                }

                node = node.Next;
            }

            return sb.ToString();
        }

        public void DeleteFirst()
        {
            if(First == null)
            {
                return;
            }

            First = First.Next;
        }

        public void DeleteLast()
        {
            if(Last == null || First == null)
            {
                return;
            }

            var previousNode = First;
            var currentNode = First.Next;

            while(currentNode != null)
            {
                if(currentNode != Last)
                {
                    previousNode = currentNode;
                }

                currentNode = currentNode.Next;
            }

            Last = previousNode;
            previousNode.Next = null;            
        }

        public bool Contains(int value)
        {
            return IndexOf(value) != -1;
        }

        public int IndexOf(int value)
        {
            var index = 0;
            var currentNode = First;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    return index;
                }

                currentNode = currentNode.Next;
                index++;
            }

            return -1;
        }

        private class Node
        {
            public Node Next;
            public int Value;

            public Node(int value)
            {
                this.Value = value;
            }
        }
    }
}
