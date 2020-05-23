using DataStructuresTutorials;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests
{
    [TestClass]
    public class StringProblemsTest
    {
        [TestMethod]
        public void should_return_the_reversed_form_of_a_string()
        {
            var reverser = new StringProblems();
            var reversedString = reverser.ReverseString("hello");

            reversedString.Should().Equals("olleh");
        }

        [TestMethod]
        public void should_return_an_empty_string_if_the_string_to_reverse_is_empty()
        {
            var reverser = new StringProblems();
            var reversedString = reverser.ReverseString("");

            reversedString.Should().Equals("");
        }

        [TestMethod]
        public void should_return_true_if_the_string_is_balanced()
        {
            var balancer = new StringProblems();
            var stringToCheck = "[<<>>([])]";
            balancer.isBalancedParenthesis(stringToCheck).Should().BeTrue();
        }

        [TestMethod]
        public void should_return_false_if_the_string_is_not_balanced()
        {
            var balancer = new StringProblems();
            var stringToCheck = "[<<>>([))]";
            balancer.isBalancedParenthesis(stringToCheck).Should().BeFalse();
        }

        [TestMethod]
        public void should_return_false_if_the_string_is_not_balanced_because_of_a_bracket_that_wasnt_closed()
        {
            var balancer = new StringProblems();
            var stringToCheck = "<[<<>>([))]"; //needs the end to be a >
            balancer.isBalancedParenthesis(stringToCheck).Should().BeFalse();
        }

        [TestMethod]
        public void should_return_false_if_the_string_is_not_balanced_because_the_opposites_are_used()
        {
            var balancer = new StringProblems();
            var stringToCheck = ")("; //needs the end to be a >
            balancer.isBalancedParenthesis(stringToCheck).Should().BeFalse();
        }

        [TestMethod]
        public void should_return_true_if_the_string_is_empty()
        {
            var balancer = new StringProblems();
            var stringToCheck = "";
            balancer.isBalancedParenthesis(stringToCheck).Should().BeTrue();
        }
    }
}
