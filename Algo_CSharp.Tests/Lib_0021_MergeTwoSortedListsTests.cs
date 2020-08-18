using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0021_MergeTwoSortedLists;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_0021_MergeTwoSortedListsTests
    {

        [Theory]
        [ClassData(typeof(MergeTwoListsTestData))]
        public void MergeTwoListsTest(ListNode l1, ListNode l2, ListNode expected)
        {
            var s = new Solution();
            
            Assert.Equal(
                s.OutputArray(expected), 
                s.OutputArray(s.MergeTwoLists(l1, l2))
                );
        }
    }

    public class MergeTwoListsTestData : IEnumerable<object[]>
    {
        Solution _solution = new Solution();
        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[]
            {
                _solution.InitWithIntArray( new []{ 1}),
                _solution.InitWithIntArray( new []{ 2 }),
                _solution.InitWithIntArray( new []{ 1,2 })
            };

            yield return new object[]
            {
               _solution.InitWithIntArray( new []{ 1, 2, 4 }),
               _solution.InitWithIntArray( new []{ 1, 3, 4 }),
               _solution.InitWithIntArray( new []{ 1,1,2,3,4,4 })
            };
            yield return new object[]
            {
                _solution.InitWithIntArray( new []{ 1, 4,54,346,4433 }),
                _solution.InitWithIntArray( new []{ 2, 234,444, 4211 }),
                _solution.InitWithIntArray( new []{ 1,2,4,54,234,346,444,4211,4433 })
            };
            yield return new object[]
            {
                _solution.InitWithIntArray( new []{ 1, 3,5}),
                _solution.InitWithIntArray( new []{ 0, 2,5 }),
                _solution.InitWithIntArray( new []{ 0,1,2,3,5,5 })
            };

            yield return new object[]
            {
                _solution.InitWithIntArray( new []{ 1, 3,5,77}),
                _solution.InitWithIntArray( new []{ 0, 22,55,56,67,79 }),
                _solution.InitWithIntArray( new []{ 0,1,3,5,22,55,56,67,77,79 })
            };
            yield return new object[]
            {
                _solution.InitWithIntArray( new []{ 0,1, 22,55,56,67,79 }),
                _solution.InitWithIntArray( new []{ 4,5,77}),
                _solution.InitWithIntArray( new []{  0,1,4,5,22,55,56,67,77,79  })
            };

            yield return new object[]
            {
                _solution.InitWithIntArray( new []{ 0,1, 22,55,56,67,79 }),
                _solution.InitWithIntArray( new []{ 4,5,55}),
                _solution.InitWithIntArray( new []{  0,1,4,5,22,55,55,56,67,79  })
            };
            yield return new object[]
            {
                _solution.InitWithIntArray( new []{ 0,1, 22,55,56,67,79 }),
                _solution.InitWithIntArray( new []{ 4,5,53}),
                _solution.InitWithIntArray( new []{  0,1,4,5,22,53,55,56,67,79  })
            };
            yield return new object[]
            {
                _solution.InitWithIntArray( new []{ 4,5,53}),
                _solution.InitWithIntArray( new []{ 0,1, 22,55,56,67,79 }),
               
                _solution.InitWithIntArray( new []{  0,1,4,5,22,53,55,56,67,79 })
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
