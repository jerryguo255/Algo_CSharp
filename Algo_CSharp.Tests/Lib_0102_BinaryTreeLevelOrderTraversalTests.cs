using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TargetSolution = Lib_0102_BinaryTreeLevelOrderTraversal.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;
namespace Algo_CSharp.Tests
{
    public class Lib_0102_BinaryTreeLevelOrderTraversalTests
    {
        [Theory]
        [ClassData(typeof(LevelOrderTestData))]
        public void LevelOrderTest(int?[] input, IList<IList<int>> expected)
        {
            var tos = new ToolSolution();
            var tas = new TargetSolution();

            var t = tos.GetABinaryTreeWithLevelOrderArray(input);
            Assert.Equal(expected, tas.LevelOrder(t));
        }
    }

    public class LevelOrderTestData : IEnumerable<Object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
              new int?[]{3,9,20,null,null,15,7},
              new List<IList<int>>
              {
                  new List<int>{3},
                  new List<int>{9,20},
                  new List<int>{15,7}
              }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
