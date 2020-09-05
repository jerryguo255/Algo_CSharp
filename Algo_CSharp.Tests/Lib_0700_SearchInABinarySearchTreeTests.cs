using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;
using TargetSolution = Lib_0700_SearchInABinarySearchTree.Solution;

namespace Algo_CSharp.Tests
{
    public class Lib_0700_SearchInABinarySearchTreeTests
    {
        private ToolSolution _tos = new ToolSolution();
        private TargetSolution _tas = new TargetSolution();

        [Theory]
        [ClassData(typeof(SearchBSTTestData))]
        public void SearchBSTTest(int?[] root,int val, int?[] expected)
        {
           var actual= _tas.SearchBST(_tos.GetABinaryTreeWithLevelOrderArray(root), val);
           

           Assert.Equal(expected, _tos.ConvertBSTToLevelOrderArray(actual));
        }
    }

    public class SearchBSTTestData:IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new int?[] {4, 2, 7, 1, 3},2,
                new int?[] {2, 1, 3}
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
