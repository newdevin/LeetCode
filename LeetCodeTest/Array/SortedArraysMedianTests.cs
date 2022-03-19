using LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeTest.Array
{
    public class SortedArraysMedianTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        public void SortedArraysMedianTest(int[] nums1, int[] nums2, double expected)
        {
            var actual = SortedArraysMedian.Median(nums1, nums2);
            Assert.Equal(expected, actual);
        }
    }
}
