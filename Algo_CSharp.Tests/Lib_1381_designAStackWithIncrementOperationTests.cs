using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lib_1381_DesignAStackWithIncrementOperation;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_1381_designAStackWithIncrementOperationTests
    {

        [Theory]
        [InlineData(2323)]
        [InlineData(666)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]

        public void PushNPopSingleItemTest(int val)
        {
            var c = new CustomStack(3);
            c.Push(val);
            Assert.Equal(val, c.Pop());

        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData(new[] { 0, int.MaxValue, int.MinValue })]
        public void PushNPopMultipleItemsTest(int[] vals)
        {
            var s = new CustomStack(vals.Length);

            foreach (var val in vals)
            {
                s.Push(val);
            }

            int[] actualVals = new int[s.MaxSize];

            for (int i = 0; i < actualVals.Length; i++)
            {
                actualVals[i] = s.Pop();
            }

            Assert.Equal(vals, actualVals.Reverse());
        }


        [Theory]
        [InlineData(5, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData(2, new[] { 0, int.MaxValue, int.MinValue })]
        public void PushItemsWhenOverSizeTest(int maxSize, int[] vals)
        {
            var s = new CustomStack(maxSize);

            foreach (var val in vals)
            {
                s.Push(val);
            }

            Assert.True(s.Pop() == vals[maxSize - 1]);//0-indexed); 
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 })]
        public void PopWhenEmpty(int[] vals)
        {
            var s = new CustomStack(vals.Length);
            foreach (var val in vals)
            {
                s.Push(val);
            }

            for (int i = 0; i < s.MaxSize; i++)
            {
                s.Pop();

            }
            Assert.True(s.Pop() == -1);

        }


        [Theory]
        [InlineData(3, 50, new[] { 1, 2, 3, 4, 5 }, new[] { 51, 52, 53, 4, 5 })]
        [InlineData(6, 20, new[] { 1, 2, 3, 4, 5 },  new[] { 21, 22, 23, 24, 25 })]
        [InlineData(0, 20, new[] { 1, 2, 3, 4, 5 },   new[] { 1, 2, 3, 4, 5 })]
        [InlineData(10, 0, new[] { 1, 2, 3, 4, 5 },  new[] { 1, 2, 3, 4, 5 })]
        public void IncrementTest(int k, int val, int[] original,  int[] afterIncrsing)
        {

            var s = new CustomStack(original.Length);

            for (int i = 0; i < s.MaxSize; i++)
            {
                s.Push(original[i]);
            }

            s.Increment(k,val);

            var actualVals = new int[s.MaxSize];
            for (int i = 0; i < s.MaxSize; i++)
            {
                actualVals[i] = s.Pop();

            }
            Assert.Equal(afterIncrsing, actualVals.Reverse());

        }
    }
}
