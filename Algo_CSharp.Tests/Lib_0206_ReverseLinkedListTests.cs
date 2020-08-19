using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0021_MergeTwoSortedLists;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_0206_ReverseLinkedListTests
    {
        [Theory]
        [ClassData(typeof(ReverseListTestData))]

        public void ReverseListTest(ListNode input,ListNode expectedListNode)
        {
            var s = new Lib_0206_ReverseLinkedList.Solution();

           var actualListNode= s.ReverseList(input);
            
           var toolSolution = new Solution();
          var actualValue= toolSolution.OutputArray(actualListNode);
            var expectedValue = toolSolution.OutputArray(expectedListNode);
            Assert.Equal(expectedValue, actualValue);
        }
    }

    public class ReverseListTestData:IEnumerable<object[]>
    {
        Solution  s = new Solution();
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                s.InitWithIntArray(new []{1,2,3,4,5}),
                s.InitWithIntArray(new []{5,4,3,2,1})
            };

            yield return new object[]
            {
                s.InitWithIntArray(new []{1}),
                s.InitWithIntArray(new []{1})
            };
            yield return new object[]
            {
                s.InitWithIntArray(new []{5,12,5,643,3,int.MaxValue,-4,56}),
                s.InitWithIntArray(new []{56,-4,int.MaxValue,3,643,5,12,5})
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
