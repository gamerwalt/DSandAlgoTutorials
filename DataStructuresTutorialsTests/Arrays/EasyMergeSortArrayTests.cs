using DataStructuresTutorials.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorialsTests.Arrays
{
    [TestClass]
    public class EasyMergeSortArrayTests
    {
        [TestMethod]
        public void last_index_should_be_6()
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };
            var m = 3;
            var n = 3;

            LeetCodeArrayProblems.MergeSortArray(nums1, m, nums2, n);
        }

        [TestMethod]
        public void when_zero_is_passed_through()
        {
            var nums1 = new int[] { 0 };
            var nums2 = new int[] { 0 };
            var m = 1;
            var n = 1;

            LeetCodeArrayProblems.MergeSortArray(nums1, m, nums2, n);
        }
    }
}
