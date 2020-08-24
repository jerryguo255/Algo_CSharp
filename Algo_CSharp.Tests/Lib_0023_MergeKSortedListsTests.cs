using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0021_MergeTwoSortedLists;
using ToolSolution = Lib_0021_MergeTwoSortedLists.Solution;
using TargetSolution = Lib_0023_MergeKSortedLists.Solution;

using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_0023_MergeKSortedListsTests
    {
        [Theory]
        [ClassData(typeof(MergeKListsTestData))]
        public void MergeKListsTest(ListNode[] lists, ListNode expected)
        {
            var tas = new TargetSolution();
            var tos = new ToolSolution();
            var actualValue = tos.OutputArray(tas.MergeKLists(lists));
            var expectedValue = tos.OutputArray(expected);
            Assert.Equal(expectedValue, actualValue);
        }
    }

    public class MergeKListsTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var tos = new ToolSolution();

            yield return new object[]
            {
                new ListNode[]
                {
                    tos.InitWithIntArray(new[] {1, 4, 5}),
                    tos.InitWithIntArray(new[] {1, 3, 4}),
                    tos.InitWithIntArray(new[] {2, 6}),
                },

                tos.InitWithIntArray(new[] {1, 1, 2, 3, 4, 4, 5, 6})
            };
            yield return new object[]
            {
                new ListNode[]
                {
                    tos.InitWithIntArray(new[] {1, 4, 5}),
                    tos.InitWithIntArray(new[] {1, 3, 4,5}),
                    tos.InitWithIntArray(new[] {7}),
                },

                tos.InitWithIntArray(new[] {1, 1,  3, 4, 4, 5,5, 7})
            };
            yield return new object[]
            {
                new ListNode[]
                {
                    tos.InitWithIntArray(null),
                    tos.InitWithIntArray(new[] {1, 3, 4,5}),
                    tos.InitWithIntArray(new[] {7}),
                },

                tos.InitWithIntArray(new[] { 1,  3, 4,  5, 7})
            };
            yield return new object[]
            {
                new ListNode[]
                {
                    tos.InitWithIntArray(null),
                    tos.InitWithIntArray(null),
                },

                tos.InitWithIntArray(null)
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
