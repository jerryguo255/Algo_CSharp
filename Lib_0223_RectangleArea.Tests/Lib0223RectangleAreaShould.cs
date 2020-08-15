using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Lib_0223_RectangleArea.Tests
{
    public class Lib0223RectangleAreaShould
    {

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
        [InlineData(-2, -2, 2, 2,-3, 1, 3, 3, 24)]// 10 r2 top half contains r1 
        [InlineData(-2, -2, 2, 2, -3, -3, -1, 3, 24)]// 11 r2 left half contains r1 
        [InlineData(-2, -2, 4, 2, 0, -4, 2, 4, 32)]// 12 r2 crosses r1 


        [InlineData(-3, -3, 5, 0, -3, -3, 3, 3, 42)]  //both left bottom point are same


        //[ClassData(typeof(ComputeRectangleAreaData))]
        public void ComputeRectanglesTotalAreaCorrect(int leftBottomXa, int leftBottomYb,
                                                 int rightTopXc, int rightTopYd,
                                                 int leftBottomXe, int leftBottomYf,
                                                 int rightTopXg, int rightTopYh, int expected)
        {
            var l0223 = new Solution();
            var result = l0223.ComputeArea(leftBottomXa, leftBottomYb,
                                            rightTopXc, rightTopYd,
                                            leftBottomXe, leftBottomYf,
                                            rightTopXg, rightTopYh);
            Assert.Equal(expected, result);
        }




        


        //[Theory]
        //[ClassData(typeof(IsContainCorrectData))]
        //public void IsContainCorrect(Rectangle r1, Rectangle r2, int expectedValue)
        //{
        //    var l0223 = new Lib_0223_RectangleArea();
        //    var acturalResult = l0223.WhichRelationship(r1, r2);
        //    Assert.Equal(expectedValue, acturalResult);
        //}

        //public class IsContainCorrectData : IEnumerable<object[]>
        //{
        //    public IEnumerator<object[]> GetEnumerator()
        //    {
        //        // 1 include 
        //        // 1.1 LB Same
        //        // r2 includes r1, return 2 when compare RT, number bigger size bigger
        //        yield return new object[]
        //        { new Rectangle(1,1,5,3),
        //            new Rectangle(1,1,6,4), 2 };

        //        // r1 includes r2, return 1
        //        yield return new object[]
        //        { new Rectangle(1,1,6,3),
        //            new Rectangle(1,1,5,3), 1 };

        //        // 1.1 /LB Same


        //        // 1.2 RT Same
        //        // r2 includes r1, return 2  when compare LB, number smaller size bigger
        //        yield return new object[]
        //        { new Rectangle(2,1,8,6),
        //            new Rectangle(1,1,8,6), 2 };

        //        // r1 includes r2, return 1
        //        yield return new object[]
        //        { new Rectangle(1,3,8,6),
        //            new Rectangle(2,3,8,6), 1 };
        //        // 1.2 /RT Same


        //        // 1.3 LB RT both not Same
        //        yield return new object[]
        //        { new Rectangle(2,3,6,5),
        //            new Rectangle(1,1,8,6), 2 };

        //        yield return new object[]
        //        { new Rectangle(0,0,0,0),
        //            new Rectangle(-1,-1,1,4), 2 };

        //        yield return new object[]
        //        { new Rectangle(51,50,55,55),
        //            new Rectangle(53,52,54,54), 1 };




        //        // 2  not include 
        //        // 2.1 LB  Same
        //        yield return new object[]
        //        { new Rectangle(2,3,5,6),
        //            new Rectangle(2,3,3,7), 0 };
        //        // 2.2 RT  Same
        //        yield return new object[]
        //        { new Rectangle(3,2,5,6),
        //            new Rectangle(2,4,5,6), 0 };
        //        // 2  /not include 
        //    }

        //    IEnumerator IEnumerable.GetEnumerator()
        //    {
        //        return GetEnumerator();
        //    }
        //}

    }

    //public class ComputeRectangleAreaData: IEnumerable<object[]>
    //{
    //    public IEnumerator<object[]> GetEnumerator()
    //    {
    //        yield return new object[] { 0, 0, 3, 2, 6 };
    //        yield return new object[] { 0, 0, 13245, 21545, 285363525 };
    //        yield return new object[] { -3, 0, 3, 4, 24 };
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}
}
