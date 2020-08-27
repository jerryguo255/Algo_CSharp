using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Lib_0028_ImplementStrStr;

namespace Algo_CSharp.Tests
{
   public class Lib_0028_ImplementStrStrTests
    {
        [Theory]
        [InlineData("hello","ll",2)]
        [InlineData("hello", "lo", 3)]
        [InlineData("hello", "aa", -1)]
        [InlineData("hello", "o", 4)]
        [InlineData("hello", "he", 0)]
        [InlineData("hellojerrythisisasunnyday", "err", 6)]
        [InlineData("hellojerrythisisasunnyday", "this", 10)]
        [InlineData("hellojerrythisisasunnyday", "sunnyday", 17)]
        [InlineData("", "", 0)]
        [InlineData("", "a", -1)]



        public void StrStrTest(string haystack, string needle ,
            int expectedIndex)
        {
            var s = new Solution();
            Assert.Equal(expectedIndex, s.StrStr(haystack, needle));
        }
    }
}
