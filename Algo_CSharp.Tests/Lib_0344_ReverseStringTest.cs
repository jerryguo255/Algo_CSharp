using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Lib_0344_ReverseString;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_0344_ReverseStringTest
    {
        private readonly Solution _s = new Solution();

        [Theory]
        [ClassData(typeof(ReverseStringTestData))]
        public void ReverseStringTest(char[] s, char[] expected)
        {
            Assert.Equal(expected, _s.ReverseString(s));
        }
    }

    public class ReverseStringTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
               new[]{'j', 'e', 'r', 'r', 'y' },
               new[]{'y', 'r', 'r', 'e', 'j' }
            };
            yield return new object[]
            {
               new[]{'a', 'b', 'c', 'd', 'e' ,'f'},
               new[]{'f','e', 'd', 'c', 'b', 'a' }
            };
            yield return new object[]
            {
                new[]{'a', 'b', 'c', 'd'},
                


                new[]{ 'd', 'c', 'b', 'a' }
            };
            yield return new object[]
            {
               new[]{'a', 'b', 'c'},
               new[]{'c','b', 'a' }
            };
            yield return new object[]
            {
               new[]{'a', 'b'},
               new[]{'b', 'a' }
            };
            yield return new object[]
            {
               new[]{'a'},
               new[]{'a' }
            };
            yield return new object[]
                {
                   new[]{'A',' ','m','a','n',',',' ','a',' ','p','l','a','n',',',' ','a',' ','c','a','n','a','l',':',' ','P','a','n','a','m','a'},




                   new[]{'a','m','a','n','a','P',' ',':','l','a','n','a','c',' ','a',' ',',','n','a','l','p',' ','a',' ',',','n','a','m',' ','A'},
                   //new[]{'a','m','a','n','a','P',' ',':','l','a','n','a','c',' ',' ','a',',','n','a','l','p',' ','a',' ',',','n','a','m',' ','A'}
                };

            //yield return new object[]
            //{
            //    new[]{'1','2','3','4','5','6','7','8','9','0','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t'},


            //    new[]{'t','s','r','q','p','o','n','m','l','k','j','i','h','g','f','e','d','c','b','a','0','9','8','7','6','5','4','3','2','1'}
            //    //new[]{'a','m','a','n','a','P',' ',':','l','a','n','a','c',' ',' ','a',',','n','a','l','p',' ','a',' ',',','n','a','m',' ','A'}
            //};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
