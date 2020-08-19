using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0021_MergeTwoSortedLists;
using Xunit;
using Lib_0876_MiddleOfTheLinkedList;
using ToolSolution = Lib_0021_MergeTwoSortedLists.Solution;
using TargetSolution = Lib_0876_MiddleOfTheLinkedList.Solution;


namespace Algo_CSharp.Tests
{
   public class Lib_0876_MiddleOfTheLinkedListTests
    {
        private readonly TargetSolution _targetSolution = new TargetSolution();
        private readonly ToolSolution _toolSolution = new ToolSolution();

        [Theory]
        [ClassData(typeof(MiddleNodeTestData))]
        public void MiddleNodeTest(ListNode input, ListNode expectedListNode)
        {
            if (input == null)
            {
                Assert.Null(expectedListNode);
            }
            else
            {
                var actualValue = _toolSolution.OutputArray(_targetSolution.MiddleNode(input));
                var expectedValue = _toolSolution.OutputArray(expectedListNode);
                Assert.Equal(expectedValue, actualValue);
            }
        }
    }

   public class MiddleNodeTestData :IEnumerable<object[]>
   {
       private readonly ToolSolution _toolSolution = new ToolSolution();

       public IEnumerator<object[]> GetEnumerator()
       {
           yield return new object[]
           {
                _toolSolution.InitWithIntArray(new[]{1,2,3,4,5}),
                _toolSolution.InitWithIntArray(new[]{3,4,5}),
           };

           yield return new object[]
           {
               _toolSolution.InitWithIntArray(new[]{1,2,3,4,5,6}),
               _toolSolution.InitWithIntArray(new[]{4,5,6})
           };
           yield return new object[]
           {
               _toolSolution.InitWithIntArray(new[]{1}),
               _toolSolution.InitWithIntArray(new[]{1})
           };
           yield return new object[]
           {
               null,
               null
           };
           yield return new object[]
           {
               _toolSolution.InitWithIntArray(new[]{1,2}),
               _toolSolution.InitWithIntArray(new[]{2})
           };
        }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }
   }
}
