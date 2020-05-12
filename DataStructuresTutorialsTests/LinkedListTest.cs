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

            l.AddFirst(10);
            
            var output = l.Print();
            output.Should().Be("10");
        }

        [TestMethod]
        public void should_be_able_to_add_to_the_last_of_a_linked_list()
        {
            var l = new LinkedList();
            l.AddFirst(10);
            l.AddLast(20);

            var output = l.Print();
            output.Should().Be("10, 20");
        }

        [TestMethod]
        public void should_be_able_to_add_to_the_last_of_a_linked_list_if_we_have_more_items()
        {
            var l = new LinkedList();
            l.AddFirst(10);
            l.AddFirst(5);
            l.AddLast(20);

            var output = l.Print();
            output.Should().Be("5, 10, 20");
        }

        [TestMethod]
        public void should_be_able_to_add_to_the_last_of_a_linked_list_if_we_have_more_and_more_items()
        {
            var l = new LinkedList();
            l.AddFirst(10);
            l.AddFirst(5);
            l.AddLast(15);
            l.AddLast(20);

            var output = l.Print();
            output.Should().Be("5, 10, 15, 20");
        }

        [TestMethod]
        public void should_be_able_to_delete_the_first_node()
        {
            var l = new LinkedList();
            l.AddFirst(10);
            l.AddFirst(5);
            l.AddLast(15);
            l.AddLast(20);

            l.DeleteFirst();

            var output = l.Print();
            output.Should().Be("10, 15, 20");
        }

        [TestMethod]
        public void should_be_able_to_delete_the_first_node_even_if_we_have_just_one_node()
        {
            var l = new LinkedList();
            l.AddFirst(10);

            l.DeleteFirst();

            var output = l.Print();
            output.Should().Be("");
        }

        [TestMethod]
        public void should_be_able_to_delete_the_last_node_if_we_have_multiple_nodes()
        {
            var l = new LinkedList();
            l.AddFirst(10);
            l.AddFirst(5);
            l.AddLast(15);
            l.AddLast(20);

            l.DeleteLast();

            var output = l.Print();
            output.Should().Be("5, 10, 15");
        }

        [TestMethod]
        public void should_be_able_to_delete_the_last_node_even_if_we_have_just_one_node()
        {
            var l = new LinkedList();
            l.AddFirst(10);

            l.DeleteFirst();

            var output = l.Print();
            output.Should().Be("");
        }

        [TestMethod]
        public void should_return_true_if_the_value_exists()
        {
            var l = new LinkedList();
            l.AddFirst(10);
            l.AddFirst(5);
            l.AddLast(15);
            l.AddLast(20);

            var contains = l.Contains(15);
            contains.Should().BeTrue();
        }

        [TestMethod]
        public void should_return_false_if_the_value_does_not_exists()
        {
            var l = new LinkedList();
            l.AddFirst(10);
            l.AddFirst(5);
            l.AddLast(15);
            l.AddLast(20);

            var contains = l.Contains(3);
            contains.Should().BeFalse();
        }

        [TestMethod]
        public void should_return_false_if_the_value_does_not_exists_even_if_we_have_one_node()
        {
            var l = new LinkedList();
            l.AddFirst(10);

            var contains = l.Contains(3);
            contains.Should().BeFalse();
        }

        [TestMethod]
        public void should_return_true_if_the_value_exists_even_if_we_have_one_node()
        {
            var l = new LinkedList();
            l.AddFirst(10);

            var contains = l.Contains(10);
            contains.Should().BeTrue();
        }

        [TestMethod]
        public void should_return_negative_1_if_the_value_does_not_exists()
        {
            var l = new LinkedList();
            l.AddFirst(10);
            l.AddFirst(5);
            l.AddLast(15);
            l.AddLast(20);

            var indexOf = l.IndexOf(3);
            indexOf.Should().Be(-1);
        }

        [TestMethod]
        public void should_return_negative_1_if_the_value_does_not_exists_and_we_have_one_node()
        {
            var l = new LinkedList();
            l.AddFirst(10);

            var indexOf = l.IndexOf(3);
            indexOf.Should().Be(-1);
        }

        [TestMethod]
        public void should_return_the_index_of_the_value_if_the_value_exists()
        {
            var l = new LinkedList();
            l.AddFirst(10);
            l.AddFirst(5);
            l.AddLast(15);
            l.AddLast(20);

            var indexOf = l.IndexOf(20);
            indexOf.Should().Be(3);
        }

        [TestMethod]
        public void should_return_the_index_of_the_value_if_the_value_exists_and_we_have_one_node()
        {
            var l = new LinkedList();
            l.AddFirst(10);

            var indexOf = l.IndexOf(10);
            indexOf.Should().Be(0);
        }

        [TestMethod]
        public void should_return_negative_1_if_we_have_no_nodes()
        {
            var l = new LinkedList();

            var indexOf = l.IndexOf(10);
            indexOf.Should().Be(-1);
        }
    }
}
