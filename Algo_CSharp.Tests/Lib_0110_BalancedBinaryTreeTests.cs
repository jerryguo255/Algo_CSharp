using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TargetSolution = Lib_0110_BalancedBinaryTree.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;

namespace Algo_CSharp.Tests
{
   public class Lib_0110_BalancedBinaryTreeTests
    {
        [Theory]
        [ClassData(typeof(IsBalancedTestData))]
        public void IsBalancedTest(int?[] input,bool expected)
        {
            var tos = new ToolSolution();
            var tas = new TargetSolution();
            Assert.Equal(expected,tas.IsBalanced( tos.GetABinaryTreeWithLevelOrderArray(input)));
        } 
    }

   public class IsBalancedTestData: IEnumerable<object[]>
   {
       public IEnumerator<object[]> GetEnumerator()
       {
           yield return new object[]
           {
               new int?[]{ 3, 9, 20, null, null, 15, 7 },true
           };
           yield return new object[]
           {
               new int?[]{ 1,2,2,3,3,null,null,4,4 },false
           };
           yield return new object[]
           {
               new int?[]{ 1,2,2,3,null,null,3,4,null,null,4},false
           };
           yield return new object[]
           {
               new int?[]{ 1,2,null,3,null,4,null,5},false
           };
          
        }

        IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }
   }
}
