using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TargetSolution = Lib_0144_BinaryTreePreorderTraversal.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;


namespace Algo_CSharp.Tests
{
   public class Lib_0144_BinaryTreePreorderTraversalTests
    {
        [Theory]
        [ClassData(typeof(PreorderTraversalTestData))]
        public void PreorderTraversalTest(int?[] tree , int[] expected)
        {
            var tos = new ToolSolution();
            var tas = new TargetSolution();

           var t= tos.GetABinaryTreeWithLevelOrderArray(tree);
          var actual= tas.PreorderTraversal(t);
          Assert.Equal(expected,actual);

        }
    }

   internal class PreorderTraversalTestData:IEnumerable<object[]>
   {
       public IEnumerator<object[]> GetEnumerator()
       {
           yield return new object[]{ 
               new int?[] { 1,null,2,3 },
               new []{1,2,3}
           };   
       }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }
   }
}
