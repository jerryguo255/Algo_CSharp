using System;
using System.Collections.Generic;
using System.Text;
using Lib_0509_FibonacciNumber;
using Xunit;

namespace Algo_CSharp.Tests
{
 public  class Lib_0509_FibonacciNumberTests
    {
        [Theory]
        [InlineData(2, 1)]
        [InlineData(6, 8)]
        [InlineData(15, 610)]
        [InlineData(19, 4181)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]


        public void FibTest(int input, int expected)
        {
            var s = new Solution();
            Assert.Equal(expected, s.Fib(input));
        }
    }
}
