using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0108_ConvertSortedArrayToBST;
using Xunit;
using TargetSolution = Lib_0938_RangeSumOfBST.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;


namespace Algo_CSharp.Tests
{
   public class Lib_0938_RangeSumOfBSTTests
    {
        [Theory]
        [ClassData(typeof(RangeSumBSTTestData))]
        public void RangeSumBSTTest(int?[] levelOrderArray, int l,int r,
            int expectedResult)
        {
            var tas = new TargetSolution();
            var tos = new ToolSolution();

            tos.ConvertLevelOrderArrayToATreeNode(levelOrderArray);


            var actualValue= tas.RangeSumBST(
                tos.ConvertLevelOrderArrayToATreeNode(
                    levelOrderArray), l, r);

            Assert.Equal(expectedResult,actualValue);
        }
    }

   public class RangeSumBSTTestData:IEnumerable<object[]>
   {
       public IEnumerator<object[]> GetEnumerator()
       {
          yield return new object[]
          {
              new int? []{ 10, 5, 15, 3, 7, null, 18 }
              ,7,15,32
          };
          yield return new object[]
          {
              new int? []{ 10, 5, 15, 3, 7, 13, 18, 1, null, 6 }
              ,6,10,23
          };
        }


       IEnumerator IEnumerable.GetEnumerator()
       {
           return GetEnumerator();
       }
   }
}
