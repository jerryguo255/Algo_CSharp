using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Lib_0223_RectangleArea.Tests
{
    public class RectangleShould
    {

        [Theory]
        [InlineData(0, 0, 3, 2, 6)]
        [InlineData(0, 0, 13245, 21545, 285363525)]
        [InlineData(-3, 0, 3, 4, 24)]
        [InlineData(0, -1, 9, 2, 27)]
        [InlineData(0, 0, 0, 0, 0)]
        [InlineData(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, 0)]


        //[ClassData(typeof(ComputeRectangleAreaData))]
        public void ComputeRectangleAreaCorrect(int leftBottomX, int leftBottomY, int rightTopX, int rightTopY, int exceptedValue)
        {
            var r = new Rectangle(leftBottomX, leftBottomY, rightTopX, rightTopY);

            Assert.Equal(exceptedValue, r.Area);
        }



        [Theory]
        [ClassData(typeof(HaveIsOverlapCorrectData))]
       


        //[ClassData(typeof(ComputeRectangleAreaData))]
        public void HaveIsOverlapCorrect(Rectangle r1, Rectangle other, bool exceptedValue)
        {
           
            Assert.Equal(exceptedValue, r1.IsOverlap(other));
        }
    }

    public class HaveIsOverlapCorrectData : IEnumerable<object[]>
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