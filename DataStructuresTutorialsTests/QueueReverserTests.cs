using DataStructuresTutorials;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests
{
    [TestClass]
    public class QueueReverserTests
    {
        [TestMethod]
        public void should_be_able_to_reverse_given_a_number_between_1_and_capacity_of_queue()
        {
            int k = 3;
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);

            QueueReverser reverser = new QueueReverser();
            var reversedQueue = reverser.Reverse(q, k);
            var ar = reversedQueue.ToArray();
            ar[0].Should().Be(30);
            ar[1].Should().Be(20);
            ar[2].Should().Be(10);
        }
    }
}
