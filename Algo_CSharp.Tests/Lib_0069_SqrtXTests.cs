using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Lib_0069_SqrtX;
using Shouldly;

namespace Algo_CSharp.Tests
{
    public class Lib_0069_SqrtXTests
    {
        private readonly Solution _s = new Solution();
        [Theory]
        [ClassData((typeof(MySqrtTestData)))]
        //[InlineData(4,2)]
        //[InlineData(8, 2)]
        //[InlineData(9, 3)]
        //[InlineData(6255, 79)]
        //[InlineData(0, 0)]
        //[InlineData(1, 1)]

        //[InlineData(int.MaxValue, 46340)]



        public void MySqrtTest(int x, int expectedValue)
        {
          _s.MySqrt(x).ShouldBe(expectedValue, "sd");

        }



    }

    public class MySqrtTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            for (int i = 0; i < 2000; i++)
            {
                yield return new object[] { i, (int)Math.Sqrt(i) };
               // yield return new object[] { 0, 0 };
            }
          

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
