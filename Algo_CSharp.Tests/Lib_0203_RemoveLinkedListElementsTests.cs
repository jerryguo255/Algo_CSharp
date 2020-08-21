using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0021_MergeTwoSortedLists;
using Lib_0203_RemoveLinkedListElements;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_0203_RemoveLinkedListElementsTests
    {
        Lib_0021_MergeTwoSortedLists.Solution _toolSolution
            = new Lib_0021_MergeTwoSortedLists.Solution();
        Lib_0203_RemoveLinkedListElements.Solution _targetSolution 
            = new Lib_0203_RemoveLinkedListElements.Solution();
        [Theory]
        [ClassData(typeof(RemoveElementsTestData))]
        public void RemoveElementsTest(ListNode head, int val, ListNode expected)
        {
            if (head !=null)
            {
                var actualValue = _toolSolution.OutputArray(_targetSolution.RemoveElements(head, val));
                var expectedValue = _toolSolution.OutputArray(expected);
                Assert.Equal(expectedValue, actualValue);
            }
            else
            {
                Assert.Null(_toolSolution.OutputArray(expected));
            }
         
        }
    }

    public class RemoveElementsTestData : IEnumerable<object[]>
    {
        Lib_0021_MergeTwoSortedLists.Solution _toolSolution 
            = new Lib_0021_MergeTwoSortedLists.Solution();
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1,2,6,3,4,5,6}),
                6,
                _toolSolution.InitWithIntArray( new []{1,2,3,4,5})
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1}),
                1,
                null
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1}),
                2,
                _toolSolution.InitWithIntArray(new []{1})
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1,1}),
                1,
                null
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1,1,1}),
                1,
                null
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1,2,2,1}),
                2,
                _toolSolution.InitWithIntArray( new []{1,1})
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1,1,1,1,1,1,1,1,1,1}),
                1,
                null
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1,1,2,3,5,66}),
                1,
                _toolSolution.InitWithIntArray(new []{2,3,5,66})
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1,1,1,2,3,5,66}),
                1,
                _toolSolution.InitWithIntArray(new []{2,3,5,66})
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1,1,1,1,1,1,1,1,1,2,3,5,66}),
                1,
                _toolSolution.InitWithIntArray(new []{2,3,5,66})
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{2,3,5,66,1,1,1,1,1,1,1,1,1}),
                1,
                _toolSolution.InitWithIntArray(new []{2,3,5,66})
            };
            yield return new object[]
            {
                _toolSolution.InitWithIntArray( new []{1,1,2,3,5,66}),
               66,
                _toolSolution.InitWithIntArray(new []{1,1,2,3,5})
            };

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
