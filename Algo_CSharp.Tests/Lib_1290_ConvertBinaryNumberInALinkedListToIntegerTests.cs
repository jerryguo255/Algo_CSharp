using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0021_MergeTwoSortedLists;
using Xunit;
using Lib_1290_ConvertBinaryNumberInALinkedListToInteger;

namespace Algo_CSharp.Tests
{
   public class Lib_1290_ConvertBinaryNumberInALinkedListToIntegerTests
    {
        [Theory]
        [ClassData(typeof(GetDecimalValueTestData))]
        public void GetDecimalValueTest(ListNode listNode, int expected)
        {
            var s = new Lib_1290_ConvertBinaryNumberInALinkedListToInteger.Solution();
            Assert.Equal(expected,s.GetDecimalValue(listNode));
        }

    }

   public class GetDecimalValueTestData : IEnumerable<object[]>
   {
       private Lib_0021_MergeTwoSortedLists.Solution s 
           = new Lib_0021_MergeTwoSortedLists.Solution();
       public IEnumerator<object[]> GetEnumerator()
       {
           yield return new object[]
           {
               s.InitWithIntArray(new []{1,0,1}),5
           };
           yield return new object[]
           {
               s.InitWithIntArray(new []{0}),0
           };
           yield return new object[]
           {
               s.InitWithIntArray(new []{1}),1
           };
           yield return new object[]
           {
               s.InitWithIntArray(new []{1,0,0,1,0,0,1,1,1,0,0,0,0,0,0}),18880
           };
           yield return new object[]
           {
               s.InitWithIntArray(new []{0,0}),0
           };
        }

       IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }
   }
}
