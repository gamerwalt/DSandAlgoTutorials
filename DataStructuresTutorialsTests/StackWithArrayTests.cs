using DataStructuresTutorials;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests
{
    [TestClass]
    public class StackWithArrayTests
    {
        [TestMethod]
        public void should_be_able_to_add_to_the_stack()
        {
            var stack = new StackWithArray(4);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            var result = stack.ToString();
            result.Should().Be("1234");
        }

        [TestMethod]
        public void should_be_able_to_add_to_the_stack_even_if_it_gets_full_of_the_original_capacity()
        {
            var stack = new StackWithArray(4);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            var result = stack.ToString();
            result.Should().Be("123456");
        }

        [TestMethod]
        public void should_be_able_to_remove_an_item_from_the_stack()
        {
            var stack = new StackWithArray(4);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            var poppedItem = stack.Pop();
            
            var result = stack.ToString();
            
            result.Should().Be("123");
            poppedItem.Should().Be(4);
        }

        [TestMethod]
        public void should_be_able_to_remove_an_item_from_the_stack_twice()
        {
            var stack = new StackWithArray(4);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            var poppedItem1 = stack.Pop();
            var poppedItem2 = stack.Pop();

            var result = stack.ToString();

            result.Should().Be("12");
            poppedItem1.Should().Be(4);
            poppedItem2.Should().Be(3);
        }

        [TestMethod]
        public void should_be_able_to_peek_at_an_item_in_the_stack()
        {
            var stack = new StackWithArray(4);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            var peekedItem = stack.Peek();

            var result = stack.ToString();

            result.Should().Be("1234");
            peekedItem.Should().Be(4);
        }
    }
}
