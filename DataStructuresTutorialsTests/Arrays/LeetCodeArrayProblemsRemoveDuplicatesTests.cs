using DataStructuresTutorials.Arrays;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests.Arrays
{
    [TestClass]
    public class LeetCodeArrayProblemsRemoveDuplicatesTests
    {
        [TestMethod]
        public void should_return_2_given_the_array_in_the_method()
        {
            var nums = new int[] {1, 1, 2};

            var result = LeetCodeArrayProblems.RemoveDuplicates(nums);

            result.Should().Be(2);
        }

        [TestMethod]
        public void should_return_5_given_the_array_in_the_method()
        {
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            var result = LeetCodeArrayProblems.RemoveDuplicates(nums);

            result.Should().Be(5);
        }
    }
}
