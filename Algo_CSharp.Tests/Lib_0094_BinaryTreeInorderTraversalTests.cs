using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TargetSolution = Lib_0094_BinaryTreeInorderTraversal.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;

namespace Algo_CSharp.Tests
{
   public   class Lib_0094_BinaryTreeInorderTraversalTests
    {
       

        [Theory]
        [ClassData(typeof(InorderTraversalTestData))]
        public void InorderTraversalTest(int?[] data, List<int> expected)
        {
            var tos = new ToolSolution();
            var tas = new TargetSolution();

            var t = tos.GetABinaryTreeWithLevelOrderArray(data);

            ;
            Assert.Equal(expected, tas.InorderTraversal(t));


        }
    }

   public class InorderTraversalTestData: IEnumerable<object[]>
   {
       public IEnumerator<object[]> GetEnumerator()
       {
           yield return new object[]
           {
               new int?[]{1,2,3,4,5,6,7},
               new List<int>{4,2,5,1,6,3,7}
           };
           yield return new object[]
           {
               new int?[]{1,null,2,3},
               new List<int>{1,3,2}
           };
        }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }
   }
}
