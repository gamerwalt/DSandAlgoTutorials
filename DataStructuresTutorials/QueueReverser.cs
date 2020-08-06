using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresTutorials
{
    public class QueueReverser
    {
        public Queue<int> Reverse(Queue<int> q, int k)
        {
            //put the queue items into a stack taking note of the number of items you want to reverse
            var stackForReverse = new Stack<int>();
            var remainingStack = new Stack<int>();
            var counter = 0;

            foreach(var item in q)
            {
                if(counter <= (k - 1))
                {
                    stackForReverse.Push(item);
                }
                else
                {
                    remainingStack.Push(item);
                }
                counter++;
            }
            q.Clear();

            //now reverse stackForReverse
            stackForReverse.Reverse();
            foreach (var item in stackForReverse)
            {
                q.Enqueue(item);
            }
            foreach (var item in remainingStack)
            {
                q.Enqueue(item);
            }

            return q;
        }
    }
}
