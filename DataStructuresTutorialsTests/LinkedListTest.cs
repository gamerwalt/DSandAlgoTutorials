using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DataStructuresTutorials;
using FluentAssertions;

namespace DataStructuresTutorialsTests
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void should_be_able_to_add_to_the_front_of_a_linked_list()
        {
            var l = new LinkedList();

            l.addFirst(10);
            
            var output = l.Print();
            output.Should().Be("10");
        }

        [TestMethod]
        public void should_be_able_to_add_to_the_last_of_a_linked_list()
        {
            var l = new LinkedList();
            l.addFirst(10);
            l.addLast(20);

            var output = l.Print();
            output.Should().Be("10, 20");
        }

        [TestMethod]
        public void should_be_able_to_add_to_the_last_of_a_linked_list_if_we_have_more_items()
        {
            var l = new LinkedList();
            l.addFirst(10);
            l.addFirst(5);
            l.addLast(20);

            var output = l.Print();
            output.Should().Be("5, 10, 20");
        }

        [TestMethod]
        public void should_be_able_to_add_to_the_last_of_a_linked_list_if_we_have_more_and_more_items()
        {
            var l = new LinkedList();
            l.addFirst(10);
            l.addFirst(5);
            l.addLast(15);
            l.addLast(20);

            var output = l.Print();
            output.Should().Be("5, 10, 15, 20");
        }

        [TestMethod]
        public void should_be_able_to_delete_the_first_node()
        {
            var l = new LinkedList();
            l.addFirst(10);
            l.addFirst(5);
            l.addLast(15);
            l.addLast(20);

            l.deleteFirst();

            var output = l.Print();
            output.Should().Be("10, 15, 20");
        }

        [TestMethod]
        public void should_be_able_to_delete_the_first_node_even_if_we_have_just_one_node()
        {
            var l = new LinkedList();
            l.addFirst(10);

            l.deleteFirst();

            var output = l.Print();
            output.Should().Be("");
        }
    }
}
