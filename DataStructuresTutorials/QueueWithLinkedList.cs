using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class QueueWithLinkedList
    {
        private LinkedList<int> items = new LinkedList<int>();
        private int count;

        public void Enqueue(int item)
        {
            items.AddLast(item);
            count++;
        }

        public int Dequeue()
        {
            if(count == 0)
            {
                throw new IndexOutOfRangeException();
            }

            var first = items.First.Value;
            count--;

            items.RemoveFirst();

            return first;
        }

        public int Peek()
        {
            if (count == 0)
            {
                throw new IndexOutOfRangeException();
            }

            return items.First.Value;
        }

        public int Size()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
