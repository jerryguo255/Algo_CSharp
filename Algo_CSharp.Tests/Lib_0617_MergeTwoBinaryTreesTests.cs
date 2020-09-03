using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TargetSolution = Lib_0617_MergeTwoBinaryTrees.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;

namespace Algo_CSharp.Tests
{
    public class Lib_0617_MergeTwoBinaryTreesTests
    {
        [Theory]
        [ClassData(typeof(MergeTreesTestData))]
        public void MergeTreesTest(int?[] t1, int?[] t2, int?[] expected)
        {
            var tos = new ToolSolution();
            var tas = new TargetSolution();

           var tree1 = tos.GetABinaryTreeWithLevelOrderArray(t1);
           var tree2 = tos.GetABinaryTreeWithLevelOrderArray(t2);
           

          var actual = tos.ConvertBSTToLevelOrderArray(
              tas.MergeTrees(tree1, tree2));
          Assert.Equal(expected,actual);

        }
    }

    public class MergeTreesTestData : IEnumerable<object[]>{
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
               new int?[] { 1, 3, 2, 5},
               new int?[] { 2, 1, 3, null, 4, null, 7 },
               new int?[] { 3, 4, 5, 5, 4, null, 7 }
            };

            yield return new object[]
            {
                new int?[] {1, 3, 2, 5,   6,  3},
                new int?[] {2, 1, 3, null,6,  null,123 },
                new int?[] {3, 4, 5, 5,   12, 3,  123 }
            };

            yield return new object[]
            {
                new int?[] {null},
                new int?[] {2},
                new int?[] {2}
            };


            yield return new object[]
            {
                new int?[] {1,2,null,3},
                new int?[] {1,null,2,null,3},
                new int?[] {2,2,2,3,null, null, 3}
            };


            yield return new object[]
            {
                new int?[] {3,4,5,1,2},
                new int?[] {4,1,2,1},
                new int?[] {7,5,7,2,2}
            };

            yield return new object[]
            {
                new int?[] {1,null,1,null,1,null,// 0  1  2  3  4  5
                            1,null,1,null,1,null,// 6  7  8  9  10 11
                            1,null,1,null,1,null,// 12 13 14 15 16 17
                            1,null,1,2},
                new int?[] {1,null,1,null,1,null,
                            1,null,1,null,1,2},
                new int?[] { 2,null,2,null,2,null,
                             2,null,2,null,2,2,
                             1,null,1,null,
                             1,null,1,null,1,2,null }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
