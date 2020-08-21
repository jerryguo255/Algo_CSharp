using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0021_MergeTwoSortedLists;
using Lib_0092_ReverseLinkedList_II;
using Xunit;
using ToolSolution = Lib_0021_MergeTwoSortedLists.Solution;
using TargetSolution = Lib_0092_ReverseLinkedList_II.Solution;


namespace Algo_CSharp.Tests
{
    public class Lib_0092_ReverseLinkedList_IITests
    {
        TargetSolution targetSolution = new TargetSolution();
        ToolSolution toolSolution = new ToolSolution();

        [Theory]
        [ClassData(typeof(ReverseBetweenTestData))]
        public void ReverseBetweenTest(int m, int n, ListNode head, ListNode expected)
        {
            Assert.Equal(
                toolSolution.OutputArray(expected),
                toolSolution.OutputArray(targetSolution.ReverseBetween(head, m, n))
                );
        }
    }

    public class ReverseBetweenTestData : IEnumerable<object[]>
    {
        private readonly ToolSolution _toolSolution = new ToolSolution();
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                2,4,
                _toolSolution.InitWithIntArray(new[]{1,2,3,4,5}),
                _toolSolution.InitWithIntArray(new[]{1,4,3,2,5})
            };
            yield return new object[]
            {
                3,5,
                _toolSolution.InitWithIntArray(new[]{1,2,3,4,5,6}),
                _toolSolution.InitWithIntArray(new[]{1,2,5,4,3,6})
            };
            yield return new object[]
            {
                2,4,
                _toolSolution.InitWithIntArray(null),
                null
            };
            yield return new object[]
            {
                3,4,
                _toolSolution.InitWithIntArray(new[]{1,2,3,4,5}),
                _toolSolution.InitWithIntArray(new[]{1,2,4,3,5})
            };
            yield return new object[]
            {
                3,5,
                _toolSolution.InitWithIntArray(new[]{1,2,3,4,5}),
                _toolSolution.InitWithIntArray(new[]{1,2,5,4,3})
            };
            yield return new object[]
            {
                1,3,
                _toolSolution.InitWithIntArray(new[]{1,2,3,4,5}),
                _toolSolution.InitWithIntArray(new[]{3,2,1,4,5})
            };
            yield return new object[]
            {
                1,5,
                _toolSolution.InitWithIntArray(new[]{1,2,3,4,5}),
                _toolSolution.InitWithIntArray(new[]{5,4,3,2,1})
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
