using System;
using System.Collections;
using System.Collections.Generic;
using Lib_0223_RectangleArea;
using Xunit;
using Lib_0836_RectangleOverlap;

namespace Algo_CSharp.Tests
{
    public class Lib_0836_RectangleAreaTests
    {
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
    }
}
