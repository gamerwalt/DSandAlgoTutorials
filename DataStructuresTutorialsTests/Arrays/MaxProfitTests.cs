﻿using DataStructuresTutorials.Arrays;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests.Arrays
{
    [TestClass]
    public class MaxProfitTests
    {
        [TestMethod]
        public void should_return_an_output_of_5()
        {
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };

            var result = LeetCodeArrayProblems.MaxProfit(prices);

            result.Should().Be(5);
        }

        [TestMethod]
        public void should_return_an_output_of_0()
        {
            var prices = new int[] { 7, 6, 4, 3, 1 };

            var result = LeetCodeArrayProblems.MaxProfit(prices);

            result.Should().Be(0);
        }

        [TestMethod]
        public void should_return_an_output_of_0_given_2_4_1()
        {
            var prices = new int[] { 2, 4, 1 };

            var result = LeetCodeArrayProblems.MaxProfit(prices);

            result.Should().Be(2);
        }

        ///MAX PROFIT 2
        [TestMethod]
        public void should_return_an_output_of_7_for_max_profit_2()
        {
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };

            var result = LeetCodeArrayProblems.MaxProfit2(prices);

            result.Should().Be(7);
        }

        [TestMethod]
        public void should_return_an_output_of_4_for_max_profit_2()
        {
            var prices = new int[] { 1, 2, 3, 4, 5 };

            var result = LeetCodeArrayProblems.MaxProfit2(prices);

            result.Should().Be(4);
        }
    }
}
