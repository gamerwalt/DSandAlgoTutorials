using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class PriorityQueue
    {
        private int count;
        private int[] Items;
        private int Capacity;

        public PriorityQueue(int capacity)
        {
            Capacity = capacity;
            Items = new int[Capacity];
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                throw new Exception("Queue is full.");
            }
            int i;
            for(i = count - 1; i>=0; i--)
            {
                if(Items[i] < item)
                    Items[i + 1] = Items[i];
                else
                    break;
            }

            Items[i + 1] = item;
            count++;
        }

        public bool IsFull()
        {
            return count == Capacity;
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder();
            var counter = 0;
            for(int i = 0; i<count; i++)
            {
                sb.Append(Items[i]);
                counter++;

                if (counter < count)
                {
                    sb.Append(", ");
                }
                
            }

            return sb.ToString();
        }

        public int remove()
        {
            if (isEmpty())
                throw new Exception("Queue is empty.");

            var itemToRemove = Items[count-1];
            Items[count-1] = 0;
            --count;
            return itemToRemove;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int Count()
        {
            return count;
        }
    }
}
