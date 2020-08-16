using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using Lib_0345_ReverseVowelsOfAString;
using Xunit;

namespace Algo_CSharp.Tests
{
   public class Lib_0345_ReverseVowelsOfAStringTests
    {
        private readonly Solution _solution = new Solution();
        [Theory]
        [InlineData("hello","holle")]
        [InlineData("leetcode", "leotcede")]
        [InlineData("jerry", "jerry")]
        [InlineData("jerryissodaa", "jarryassodie")]
        [InlineData("aA", "Aa")]



        public void ReverseVowelsTest(string s,string expected)
        {
            Assert.Equal(expected, _solution.ReverseVowels(s));
        }
    }
}
