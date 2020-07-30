using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class QueueWithStack
    {
        Stack<int> StackEnqueue = new Stack<int>();
        Stack<int> StackDequeue = new Stack<int>();

        public void Enqueue(int item)
        {
            StackEnqueue.Push(item);
        }

        public int Dequeue()
        {
            if(StackEnqueue.Count == 0 && StackDequeue.Count == 0)
            {
                throw new Exception("Stacks are empty!");
            }

            foreach(var item in StackEnqueue)
            {
                StackDequeue.Push(item);
            }

            StackEnqueue.Clear();

            var itemToRemove = StackDequeue.Pop();

            foreach (var item in StackDequeue)
            {
                StackEnqueue.Push(item);
            }

            StackDequeue.Clear();
            return itemToRemove;
        }

        public string PrintAll()
        {
            StringBuilder sb = new StringBuilder();
            var count = StackEnqueue.Count;
            foreach(var item in StackEnqueue)
            {
                sb.Append(item);
                count--;
                if(count != 0)
                {
                    sb.Append(',');
                }
            }

            return sb.ToString();
        }
    }
}
