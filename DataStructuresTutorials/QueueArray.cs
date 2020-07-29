using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class QueueArray
    {
        int count;
        int Capacity;
        int Front;
        int Rear;
        int[] items;

        public QueueArray(int capacity)
        {
            Capacity = capacity;
            items = new int[Capacity];
            Front = 0;
            Rear = 0;
        }

        public void Enqueue(int item)
        {
            if(count == items.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            items[Rear] = item;
            Rear = (Rear + 1) % Capacity;
            count++;


        }

        public int Dequeue()
        {
            if(Front == Rear)
            {
                throw new InvalidOperationException();
            }

            var itemToReturn = items[Front];
            items[Front] = 0;
            Front = (Front + 1) % Capacity;
            count--;

            return itemToReturn;
        }

        public int Peek()
        {
            return items[Front];
        }

        public bool IsEmpty()
        {
            return Front == Rear;
        }

        public bool IsFull()
        {
            return Rear == Capacity;
        }
    }
}
