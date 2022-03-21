using LeetCode.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeTest.Strings
{
    public class StringExtensionTests
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData("aab", 2)]
        [InlineData("dvdf", 3)]
        [InlineData("abcdefghij", 10)]
        [InlineData("aabcdefghij", 10)]
        [InlineData("abcdefghijj", 10)]
        [InlineData("ckilbkd", 5)]
        [InlineData("abcc", 3)]
        [InlineData("qrsvbspk", 5)]
        [InlineData("aabaab!bb", 3)]
        [InlineData("ggububgvfk", 6)]
        public void LongestSubstringWithoutRepeatingCharsTest(string input, int expected)
        {
            var actual = input.LongestSubstringWithoutRepeatingChars();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("babad",new string[] { "bab", "aba" })]
        [InlineData("cbbc", new string[] { "cbbc" })]
        [InlineData("cbbd", new string[] { "bb" })]
        [InlineData("a", new string[] { "a" })]
        [InlineData("abb", new string[] { "bb" })]
        [InlineData("ac", new string[] { "a", "c" })]
        public void LongestPalindromeSubstringTest(string input, string[] expected)
        {
            var actual = input.LongestPalindromeSubstring();
            Assert.Contains(expected, ans => ans == actual);
        }
    }
}
