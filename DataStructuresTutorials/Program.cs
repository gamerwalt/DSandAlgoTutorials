﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DataStructuresTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var QA = new QueueArray(5);
            QA.Enqueue(10);
            QA.Enqueue(20);
            QA.Enqueue(30);
            QA.Enqueue(40);

            Console.WriteLine(QA.Dequeue());
            QA.Enqueue(50);
            Console.WriteLine(QA.Peek());
            Console.WriteLine(QA.IsFull());
            Console.WriteLine(QA.Dequeue());
            QA.Enqueue(60);
            Console.WriteLine(QA.Dequeue());
            QA.Enqueue(70);
            QA.Enqueue(80);
        }

        public static bool isPalindromeNumber(int x)
        {
            if(x < 0)
            {
                return false;
            }

            int numDigits = (int)(Math.Floor(Math.Log10(x))) + 1;
            int msdMask = (int)Math.Pow(10, numDigits - 1);

            return true;
        }

        public static long reverse(int x)
        {
            long result = 0;
            long xRemaining = Math.Abs(x);
            while(xRemaining != 0)
            {
                result = result * 10 + xRemaining % 10;
                xRemaining /= 10;
            }

            return x < 0 ? -result : result;
        }

        public static void reverseQueue(Queue<int> queue)
        {
            Console.WriteLine("");
            Console.WriteLine("reversing queue");
            //the idea here I believe is to use a stack to remove the items from the queue then 
            //use the same stack to populate the queue
            var stack = new Stack<int>();
            while(queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while(stack.Count > 0)
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
