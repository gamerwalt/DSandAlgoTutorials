using DataStructuresTutorials.Arrays;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests.Arrays
{
    [TestClass]
    public class EasyMaximumSubArrayTests
    {
        [TestMethod]
        public void should_return_6()
        {
            var nums = new int[] { -2,1,-3,4,-1,2,1,-5,4};

            var result = LeetCodeArrayProblems.MaximumSubArray(nums);

            result.Should().Be(6);
        }

        [TestMethod]
        public void should_return_1()
        {
            var nums = new int[] { 1 };

            var result = LeetCodeArrayProblems.MaximumSubArray(nums);

            result.Should().Be(1);
        }

        [TestMethod]
        public void should_return_0()
        {
            var nums = new int[] { 0 };

            var result = LeetCodeArrayProblems.MaximumSubArray(nums);

            result.Should().Be(0);
        }

        [TestMethod]
        public void should_return_negative_1()
        {
            var nums = new int[] { -1 };

            var result = LeetCodeArrayProblems.MaximumSubArray(nums);

            result.Should().Be(-1);
        }

        [TestMethod]
        public void should_return_negative_2147483647()
        {
            var nums = new int[] { -2147483647 };

            var result = LeetCodeArrayProblems.MaximumSubArray(nums);

            result.Should().Be(-2147483647);
        }
    }
}
