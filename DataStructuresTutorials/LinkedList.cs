using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class LinkedList
    {
        private Node First;
        private Node Last;

        public void addFirst(int value)
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

        public void addLast(int value)
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

        public void deleteFirst()
        {
            if(First == null)
            {
                return;
            }

            First = First.Next;
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
