using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0108_ConvertSortedArrayToBST;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_0108_ConvertSortedArrayToBSTTest
    {

        [Theory]
        [ClassData(typeof(SortedArrayToBSTTestData))]
        public void SortedArrayToBSTTest(int[] sortedArray, int?[] expected)
        {
            var s = new Solution();

            Assert.Equal(expected,
                   s.ConvertBSTToLevelOrderArray(
                           s.SortedArrayToBST(sortedArray)
                             )
                        );
        }
        public class SortedArrayToBSTTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    new[]{-10,-3,0,5,9},  new int?[] { 0, -3, 9, -10, null, 5, null }
                };
                yield return new object[]
                {
                    new[]{3,4,5,6},  new int?[] {5,4,6,3,null }
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }



        [Theory]
        [ClassData(typeof(ConvertBSTToLevelOrderArrayTestData))]
        public void ConvertBSTToLevelOrderArrayTest(int[] BSTArray, int?[] expected)
        {
            var s = new Solution();
            var t = s.SortedArrayToBST(BSTArray);

            
            Assert.Equal(expected,
                    s.ConvertBSTToLevelOrderArray(t)
                );

        }
        public class ConvertBSTToLevelOrderArrayTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    new [] { 1, 2, 3, 4, 5, 6 },
                    new int?[]{ 4,2,6,1,3,5,null}
                };
                yield return new object[]
                {
                    new [] {int.MinValue,56,78,112,334,667,int.MaxValue },
                    new int?[]{ 112,56,667,int.MinValue,78,334,int.MaxValue}
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }




        [Theory]
        [ClassData(typeof(ConvertLevelOrderArrayToATreeNodeTestData))]
        public void ConvertLevelOrderArrayToATreeNodeTest(int?[] levelOrderArray ,
            int[]sortedArray)
        {
            var s = new Solution();
            var t = s.ConvertLevelOrderArrayToATreeNode(levelOrderArray);

           
            Assert.Equal(sortedArray,
                    s.ConvertBSTToSortedArray(t)
                );

        }
        public class ConvertLevelOrderArrayToATreeNodeTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    new int?[]{ 4,2,6,1,3,5,null},
                    new []{ 1,2,3,4,5,6}

                };
                yield return new object[]
                {
                    new int?[]{ 112,56,667,int.MinValue,78,334,int.MaxValue},
                    new []{ int.MinValue, 56, 78, 112, 334, 667,int.MaxValue}
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }






        //===

        [Theory]
        [ClassData(typeof(ConvertBSTToSortedArrayTestData))]
        public void ConvertBSTToSortedArrayTest( int?[] levelOrderArray, 
            int[] sortedArray)
        {
            var s = new Solution();
            var t = s.ConvertLevelOrderArrayToATreeNode(levelOrderArray);
            s.ConvertBSTToSortedArray(t);
            
            Assert.Equal(sortedArray,
                s.ConvertBSTToSortedArray(t)
            );

        }
        public class ConvertBSTToSortedArrayTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    new int?[]{ 4,2,6,1,3,5,null},
                    new []{ 1,2,3,4,5,6}

                };
                yield return new object[]
                {
                    new int?[]{ 112,56,667,int.MinValue,78,334,int.MaxValue},
                    new []{ int.MinValue, 56, 78, 112, 334, 667,int.MaxValue}
                };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
