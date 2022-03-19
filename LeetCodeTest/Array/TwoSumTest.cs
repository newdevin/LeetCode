using LeetCode.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeTest.Array
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void Sumof2_ShouldAddToTarget(int[] nums, int target, int[] expected)
        {
            var actual = TwoSum.SumOf2(nums, target);

            Assert.Equal(expected, actual);
        }
    }
}
