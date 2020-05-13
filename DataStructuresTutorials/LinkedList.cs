using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class LinkedList
    {
        private Node First;
        private Node Last;
        private int Size;

        public void AddFirst(int value)
        {
            var node = new Node(value);

            if(First == null)
            {
                First = node;
                Last = First;
                Size++;
                return;
            }

            node.Next = First;
            First = node;
            Size++;
        }

        public void AddLast(int value)
        {
            var node = new Node(value);

            if(First == null)
            {
                First = node;
                Last = First;
                Size++;
                return;
            }

            if(Last == First)
            {
                Last = node;
                First.Next = Last;
                Size++;
                return;
            }

            Last.Next = node;
            Last = node;
            Size++;
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

            if(First == Last)
            {
                First = Last = null;
                Size--;
                return;
            }

            var next = First.Next;
            First.Next = null;
            First = next;
            Size--;
        }

        public int[] ToArray()
        {
            int[] array = new int[Size];
            var current = First;
            var counter = 0;

            while(current != null)
            {
                array[counter++] = current.Value;
                current = current.Next;
            }

            return array;
        }

        public void Reverse()
        {
            if(First == null)
            {
                return;
            }

            var current = First.Next;
            var previous = First;

            while(current != null)
            {
                var temp = current.Next;

                current.Next = previous;
                previous = current;
                current = temp;
            }
            
            First.Next = null;
            Last = First;
            First = previous;
        }

        public void DeleteLast()
        {
            if(Last == null || First == null)
            {
                return;
            }

            if(First == Last)
            {
                First = Last = null;
                Size--;
                return;
            }

            var previousNode = GetPrevious(Last);

            Last = previousNode;
            Last.Next = null;
            Size--;
        }

        private Node GetPrevious(Node node)
        {
            var current = First;
            while(current != null)
            {
                if (current.Next == node) return current;
                current = current.Next;
            }

            return null;
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

        public int GetSize()
        {
            return Size;
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
