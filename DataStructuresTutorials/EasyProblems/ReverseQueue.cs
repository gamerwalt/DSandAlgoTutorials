using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.EasyProblems
{
    public class ReverseQueue
    {
        public static void reverseQueue(Queue<int> queue)
        {
            Console.WriteLine("");
            Console.WriteLine("reversing queue");
            //the idea here I believe is to use a stack to remove the items from the queue then 
            //use the same stack to populate the queue
            var stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            foreach (var item in queue)
            {
                Console.Write(item);
            }
        }
    }
}
