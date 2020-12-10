using DataStructuresTutorials.Arrays;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests.Arrays
{
    [TestClass]
    public class SearchInsertPositionTests
    {
        [TestMethod]
        public void should_return_2_when_given_an_array_where_the_value_is_found()
        {
            var nums = new int[] { 1, 3, 5, 6 };
            var target = 5;

            var result = LeetCodeArrayProblems.SearchInsert(nums, target);

            result.Should().Be(2);
        }

        [TestMethod]
        public void should_return_1_when_given_an_array_where_the_value_is_not_found()
        {
            var nums = new int[] { 1, 3, 5, 6 };
            var target = 2;

            var result = LeetCodeArrayProblems.SearchInsert(nums, target);

            result.Should().Be(1);
        }

        [TestMethod]
        public void should_return_4_when_given_the_last_position_of_the_array_is_where_the_target_should_be()
        {
            var nums = new int[] { 1, 3, 5, 6 };
            var target = 7;

            var result = LeetCodeArrayProblems.SearchInsert(nums, target);

            result.Should().Be(4);
        }

        [TestMethod]
        public void should_return_0_when_given_the_first_position_of_the_array_is_where_the_target_should_be()
        {
            var nums = new int[] { 1, 3, 5, 6 };
            var target = 0;

            var result = LeetCodeArrayProblems.SearchInsert(nums, target);

            result.Should().Be(0);
        }

        [TestMethod]
        public void should_return_1_when_given_the_second_position_of_the_array_is_where_the_target_should_be()
        {
            var nums = new int[] {-1, 1, 3, 5, 6 };
            var target = 0;

            var result = LeetCodeArrayProblems.SearchInsert(nums, target);

            result.Should().Be(1);
        }

        [TestMethod]
        public void should_return_0_when_given_the_first_position_of_the_array_is_where_the_target_should_be_2()
        {
            var nums = new int[] { 1 };
            var target = 0;

            var result = LeetCodeArrayProblems.SearchInsert(nums, target);

            result.Should().Be(0);
        }
    }
}
