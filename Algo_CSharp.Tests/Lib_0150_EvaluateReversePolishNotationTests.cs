using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Lib_0150_EvaluateReversePolishNotation;

namespace Algo_CSharp.Tests
{
   public class Lib_0150_EvaluateReversePolishNotationTests
    {
        [Theory]
        [InlineData(new[]{ "2", "1", "+", "3", "*" },9)]
        [InlineData(new[] { "4", "13", "5", "/", "+" }, 6)]
        [InlineData(new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
       // [InlineData(new[] { "2", "1", "+", "3", "*" }, 9)]

        public void EvalRPNTest(string[]input , int expected)
        {
            var s = new Solution();
            Assert.Equal(expected, s.EvalRPN(input));
        }
    }
}
