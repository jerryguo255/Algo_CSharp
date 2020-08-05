using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Lib_0223_RectangleArea.Tests
{
    public class RPointShould
    {
        [Theory]
        [ClassData(typeof(EqualsOperatorCorrectData))]
        public void HaveEqualsOperatorCorrect(RPoint x, RPoint y, bool expected)
        {
           Assert.Equal(expected, x == y); 
        }


        [Theory]
        [ClassData(typeof(HaveCompareCorrectData))]
        public void  HaveCompareToCorrect(RPoint x, RPoint y, int expected)
        {
            Assert.Equal( expected,x.CompareTo(y));

        }



        [Theory]
        [ClassData(typeof(HaveCompareCorrectFromLeftTopToRightBottomData))]
        public void HaveCompareToCorrect_FromLeftTopToRightBottom(RPoint x, RPoint y, int expected)
        {
            Assert.Equal(expected,x.CompareTo(y,true) );

        }

    }

    public class HaveCompareCorrectData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // return _data.GetEnumerator();
            yield return new object[] { new RPoint(121, 2121), new RPoint(121, 2121), 0 };
            yield return new object[] { new RPoint(120, 2121), new RPoint(121, 2121), -1 };
            yield return new object[] { new RPoint(121, 2121), new RPoint(120, 2121), 1 };
            yield return new object[] { new RPoint(2, 2), new RPoint(3, -1), 0 };
            yield return new object[] { new RPoint(-1, 3), new RPoint(2, 2), 0 };
    
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    public class HaveCompareCorrectFromLeftTopToRightBottomData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // return _data.GetEnumerator();
            yield return new object[] { new RPoint(-555, 3), new RPoint(2, 2), 1 };
            yield return new object[] { new RPoint(3, -555), new RPoint(2, 2), -1 };
            yield return new object[] { new RPoint(2, 0), new RPoint(2, 2), -1 };
            yield return new object[] { new RPoint(2, 3), new RPoint(3, -1), 1 };
            yield return new object[] { new RPoint(3, 3), new RPoint(2, 2), 0 };
            yield return new object[] { new RPoint(1, 1), new RPoint(2, 2), 0 };


        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class EqualsOperatorCorrectData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // return _data.GetEnumerator();
            yield return new object[] {new RPoint(1, 2), new RPoint(1, 2), true};
            yield return new object[] {new RPoint(1, 2), new RPoint(2, 2), false};
            yield return new object[] {new RPoint(2, 2), new RPoint(1, 2), false };
            yield return new object[] { new RPoint(int.MaxValue, int.MinValue), 
                                        new RPoint(int.MaxValue, int.MinValue), true };

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
