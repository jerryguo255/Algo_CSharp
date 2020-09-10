using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TargetSolution = Lib_0145_BinaryTreePostorderTraversal.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;

namespace Algo_CSharp.Tests
{
    public class Lib_0145_BinaryTreePostorderTraversalTests
    {
        [Theory]
        [ClassData(typeof(PostorderTraversalTestData))]
        public void PostorderTraversalTest(int?[] data, List<int> expected)
        {
            var tos = new ToolSolution();
            var tas = new TargetSolution();

            var t = tos.GetABinaryTreeWithLevelOrderArray(data);
            Assert.Equal(expected, tas.PostorderTraversal(t));

        }
    }

    public class PostorderTraversalTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int?[]{1,2,3,4,5,6,7},
                new List<int>{4,5,2,6,7,3,1}
            };
            yield return new object[]
            {
                new int?[]{1,null,2,3},
                new List<int>{3,2,1}
            };
            yield return new object[]
            {
                new int?[]{1},
                new List<int>{1}
            };
            yield return new object[]
            {
                new int?[]{null},
                null
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
