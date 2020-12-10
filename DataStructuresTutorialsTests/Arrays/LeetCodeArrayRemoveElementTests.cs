using DataStructuresTutorials.Arrays;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests.Arrays
{
    [TestClass]
    public class LeetCodeArrayRemoveElementTests
    {
        [TestMethod]
        public void should_return_2_if_given_an_array_of_size_4_with_2_duplicates_to_remove()
        {
            var nums = new int[] { 3, 2, 2, 3 };

            var result = LeetCodeArrayProblems.RemoveElement(nums, 3);

            result.Should().Be(2);
        }

        [TestMethod]
        public void should_return_5_if_given_a_simple_array()
        {
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };

            var result = LeetCodeArrayProblems.RemoveElement(nums, 2);

            result.Should().Be(5);
        }
    }
}
