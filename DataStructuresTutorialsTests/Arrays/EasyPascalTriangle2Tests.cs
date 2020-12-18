using DataStructuresTutorials.Arrays;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests.Arrays
{
    [TestClass]
    public class EasyPascalTriangle2Tests
    {
        [TestMethod]
        public void giving_a_1_row_index_should_return_2_integers_in_the_list_with_1_and_1()
        {
            var rowIndex = 1;

            var result = LeetCodeArrayProblems.EasyPascalTriangleGetRow(rowIndex);

            result[0].Should().Be(1);
            result[1].Should().Be(1);
        }

        [TestMethod]
        public void giving_a_2_row_index_should_return_3_integers_in_the_list_with_1_2_and_1()
        {
            var rowIndex = 2;

            var result = LeetCodeArrayProblems.EasyPascalTriangleGetRow(rowIndex);

            result[0].Should().Be(1);
            result[1].Should().Be(2);
            result[2].Should().Be(1);
        }

        [TestMethod]
        public void giving_a_3_row_index_should_return_4_integers_in_the_list_with_1_3_3_and_1()
        {
            var rowIndex = 3;

            var result = LeetCodeArrayProblems.EasyPascalTriangleGetRow(rowIndex);

            result[0].Should().Be(1);
            result[1].Should().Be(3);
            result[2].Should().Be(3);
            result[3].Should().Be(1);
        }
    }
}
