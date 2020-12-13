using DataStructuresTutorials.Arrays;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests.Arrays
{
    [TestClass]
    public class EasyPlusOneTests
    {
        [TestMethod]
        public void should_return_1_2_4()
        {
            var digits = new int[] { 1, 2, 3 };

            var result = LeetCodeArrayProblems.EasyPlusOne(digits);

            result[0].Should().Be(1);
            result[1].Should().Be(2);
            result[2].Should().Be(4);
        }

        [TestMethod]
        public void should_return_4_3_2_2()
        {
            var digits = new int[] { 4,3,2,1 };

            var result = LeetCodeArrayProblems.EasyPlusOne(digits);

            result[0].Should().Be(4);
            result[1].Should().Be(3);
            result[2].Should().Be(2);
            result[2].Should().Be(2);
        }

        [TestMethod]
        public void should_return_1_0_0_0()
        {
            var digits = new int[] { 9,9,9 };

            var result = LeetCodeArrayProblems.EasyPlusOne(digits);

            result[0].Should().Be(1);
            result[1].Should().Be(0);
            result[2].Should().Be(0);
            result[2].Should().Be(0);
        }
    }
}
