using DataStructuresTutorials;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests
{
    [TestClass]
    public class PriorityQueueTests
    {
        [TestMethod]
        public void should_be_able_to_add_new_items()
        {
            var pq = new PriorityQueue(5);
            pq.Enqueue(1);
            pq.Enqueue(3);
            pq.Enqueue(4);
            pq.Enqueue(5);

            var result = pq.Print();
            result.Should().Be("1, 3, 4, 5");
        }

        [TestMethod]
        public void should_be_able_to_add_new_items_to_the_middle()
        {
            var pq = new PriorityQueue(5);
            pq.Enqueue(1);
            pq.Enqueue(3);
            pq.Enqueue(4);
            pq.Enqueue(5);
            pq.Enqueue(2);

            var result = pq.Print();
            result.Should().Be("1, 2, 3, 4, 5");
        }
    }
}
