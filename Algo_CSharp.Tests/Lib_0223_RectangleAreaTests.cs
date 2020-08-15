using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Lib_0223_RectangleArea;

namespace Algo_CSharp.Tests
{
    public class Lib_0223_RectangleAreaTests
    {
        #region Main Solution Test

        [Theory]
        [InlineData(-3, 0, 3, 4, 0, -1, 9, 2, 45)]
        [InlineData(0, 0, 5, 5, 0, 0, 5, 5, 25)]
        [InlineData(0, 0, 0, 0, -1, -1, 1, 1, 4)]//完全包含
        [InlineData(-2, -2, 2, 2, 3, 3, 4, 4, 17)]//不相交
        [InlineData(3, 3, 4, 4, -2, -2, 2, 2, 17)]//不相交
        [InlineData(-2, -2, 2, 2, 2, 2, 4, 4, 20)]//相切
        [InlineData(2, 2, 4, 4, -2, -2, 2, 2, 20)]//相切
        [InlineData(-2, -2, 2, 2, 1, 1, 3, 3, 19)] //5 向上相交
        [InlineData(-2, -2, 2, 2, -3, 1, -1, 3, 19)]// 6 左上相切 
        [InlineData(-2, -2, 2, 2, -4, -3, -1, 0, 23)]// 7 右下相切 
        [InlineData(-3, -3, 3, -1, -2, -2, 2, 2, 24)]// 7 右下相切 反向
        [InlineData(-2, -2, 2, 2, -3, -3, 3, -1, 24)]// 8 r2 bottom half contains r1 
        [InlineData(-2, -2, 2, 2, 1, -3, 3, 3, 24)]// 9 r2 right half contains r1 
        [InlineData(-2, -2, 2, 2, -3, 1, 3, 3, 24)]// 10 r2 top half contains r1 
        [InlineData(-2, -2, 2, 2, -3, -3, -1, 3, 24)]// 11 r2 left half contains r1 
        [InlineData(-2, -2, 4, 2, 0, -4, 2, 4, 32)]// 12 r2 crosses r1 
        [InlineData(-3, -3, 5, 0, -3, -3, 3, 3, 42)]  //both left bottom point are same
        //[ClassData(typeof(ComputeRectangleAreaData))]
        public void Solution_ComputeAreaTest(int leftBottomXa, int leftBottomYb,
            int rightTopXc, int rightTopYd, int leftBottomXe, int leftBottomYf,
            int rightTopXg, int rightTopYh, int expected)
        {
            var s = new Solution();
            var result = s.ComputeArea(leftBottomXa, leftBottomYb,
                rightTopXc, rightTopYd,
                leftBottomXe, leftBottomYf,
                rightTopXg, rightTopYh);
            Assert.Equal(expected, result);
        }

        #endregion

        #region Rectangle Class Test
       
        [Theory(DisplayName = "untitle")]
        [InlineData(0, 0, 3, 2, 6)]
        [InlineData(0, 0, 13245, 21545, 285363525)]
        [InlineData(-3, 0, 3, 4, 24)]
        [InlineData(0, -1, 9, 2, 27)]
        [InlineData(0, 0, 0, 0, 0)]
        [InlineData(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, 0)]
        public void Rectangle_AreaTest(int leftBottomX, int leftBottomY, int rightTopX, int rightTopY, int exceptedValue)
        {
            var r = new Rectangle(leftBottomX, leftBottomY, rightTopX, rightTopY);

            Assert.Equal(exceptedValue, r.Area);
        }


        [Theory]
        [ClassData(typeof(Rectangle_IsOverlapTest_Cases))]
        public void Rectangle_IsOverlapTest(Rectangle r1, Rectangle other, bool exceptedValue)
        {
            Assert.Equal(exceptedValue, r1.IsOverlap(other));
        }

        private class Rectangle_IsOverlapTest_Cases : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {

                #region Leetcode test case (Right top)
                yield return new object[]
               {
                 new Rectangle(0,0,2,2),
                 new Rectangle(1,1,3,3),
                 true
               };
                yield return new object[]
               {
                 new Rectangle(0,0,1,1),
                 new Rectangle(1,0,2,1),
                 false
               };


                #region Reverse
                yield return new object[]
                {
                  new Rectangle(1,1,3,3),
                  new Rectangle(0,0,2,2),
                  true
                };
                yield return new object[]
                {
                  new Rectangle(1,0,2,1),
                  new Rectangle(0,0,1,1),
                  false
                };


                #endregion
                #endregion


                #region LeftBottom
                yield return new object[]
                {
                  new Rectangle(0,0,2,2),
                  new Rectangle(-2,-2,1,1),
                  true
                };
                yield return new object[]
                { // same corner
                  new Rectangle(0,0,2,2),
                  new Rectangle(-2,-2,0,0),
                  false
                };
                yield return new object[]
                { // contains another completely 
                  new Rectangle(0,0,2,2),
                  new Rectangle(-2,-2,3,3),
                  true
                };


                #region Reverse



                #endregion
                yield return new object[]
                {
                  new Rectangle(-2,-2,1,1),
                  new Rectangle(0,0,2,2),

                  true
                };
                yield return new object[]
                { // same corner

                  new Rectangle(-2,-2,0,0),
                  new Rectangle(0,0,2,2),
                  false
                };
                yield return new object[]
                { // contains another completely 
                 new Rectangle(-2,-2,3,3),
                 new Rectangle(0,0,2,2),
                 true
                };
                #endregion


                #region Left top
                yield return new object[]
               {
                 new Rectangle(0,0,2,2),
                 new Rectangle(-2,1,1,3),
                 true
               };
                yield return new object[]
               {
                 new Rectangle(0,0,1,1),
                 new Rectangle(-2,1,-1,3),
                 false
               };


                #region Reverse
                yield return new object[]
                {
                 new Rectangle(-2,1,1,3),
                 new Rectangle(0,0,2,2),
                 true
                };
                yield return new object[]
                {
                 new Rectangle(-2,1,-1,3),
                 new Rectangle(0,0,1,1),
                 false
                };


                #endregion
                #endregion


                #region RightBottom
                yield return new object[]
                {
                  new Rectangle(0,0,2,2),
                  new Rectangle(1,-1,3,1),
                  true
                };
                yield return new object[]
                { // same edge ??
                  new Rectangle(0,0,2,2),
                  new Rectangle(2,-1,4,1),
                  false
                };



                #region Reverse

                yield return new object[]
                {
                  new Rectangle(1,-1,3,1),
                  new Rectangle(0,0,2,2),

                  true
                };
                yield return new object[]
                { // same edge??
                  new Rectangle(2,-1,4,1),
                  new Rectangle(0,0,2,2),

                  false
                };


                #endregion

                #endregion




            }



            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        #endregion

        #region RPoint Class Test

        [Theory]
        [ClassData(typeof(RPoint_EqualsOperatorTest_Cases))]
        public void RPoint_EqualsOperatorTest(RPoint x, RPoint y, bool expected)
        {
            Assert.Equal(expected, x == y);
        }
        public class RPoint_EqualsOperatorTest_Cases : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                // return _data.GetEnumerator();
                yield return new object[] { new RPoint(1, 2), new RPoint(1, 2), true };
                yield return new object[] { new RPoint(1, 2), new RPoint(2, 2), false };
                yield return new object[] { new RPoint(2, 2), new RPoint(1, 2), false };
                yield return new object[] { new RPoint(int.MaxValue, int.MinValue),
                    new RPoint(int.MaxValue, int.MinValue), true };

            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }



        [Theory]
        [ClassData(typeof(RPoin_CompareToTest_Cases))]
        public void RPoin_CompareToTest(RPoint x, RPoint y, int expected)
        {
            Assert.Equal(expected, x.CompareTo(y));
        }
        public class RPoin_CompareToTest_Cases : IEnumerable<object[]>
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


        [Theory]
        [ClassData(typeof(RPoin_CompareToTest_FromLeftTopToRightBottom_Cases))]
        public void RPoin_CompareToTest_FromLeftTopToRightBottom(RPoint x, RPoint y, int expected)
        {
            Assert.Equal(expected, x.CompareTo(y, true));
        }
        public class RPoin_CompareToTest_FromLeftTopToRightBottom_Cases : IEnumerable<object[]>
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

        #endregion
    }
}
