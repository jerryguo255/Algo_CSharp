using System;
using System.Collections.Generic;
using System.Text;
using Lib_0283_MoveZeroes;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_0283_MoveZeroesTest
    {
        Solution s = new Solution();

        [Theory]
        [InlineData(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 })]
        [InlineData(new[] { 1, 2, 0, 3, 0, 4, 0, 5, 6 }, new[] { 1, 2, 3, 4, 5, 6, 0, 0, 0 })]
        [InlineData(new[] { 6, 5, 0, 0, 4, 3, 0, 0, 0, 0, 0, 0, 2, 1 }, new[] { 6, 5, 4, 3, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0 })]


        public void MoveZeroesTest(int[] input, int[] expected)
        {
            s.MoveZeroes(input);
            Assert.Equal(expected, input);
        }


    }
}
