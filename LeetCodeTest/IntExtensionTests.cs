using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeTest
{
    public class IntExtensionTests
    {
        [Theory]
        [InlineData(3, 3)]
        [InlineData(12, 21)]
        [InlineData(120, 21)]
        [InlineData(-1, -1)]
        [InlineData(2_147_483_647, 0)]
        [InlineData(-2_147_483_648, 0)]
        public void ReverseNumberTest(int num, int expected)
        {
            var actual = num.Reverse();

            Assert.Equal(expected, actual);
        }
    }
}
