using Microsoft.VisualBasic.CompilerServices;

namespace Lib_0223_RectangleArea
{
    /// <summary>
    /// From LeetCode https://leetcode.com/problems/rectangle-area/
    /// </summary>
    public class Lib_0223_RectangleArea
    {
        private bool isReverseRelationship = false;

        //int tag = 0;
        public int ComputeArea(int leftBottomXA, int leftBottomYB, int rightTopXC, int rightTopYD,
                               int leftBottomXE, int leftBottomYF, int rightTopXG, int rightTopYH)
        {
            Rectangle temp;
            var r1 = new Rectangle(leftBottomXA, leftBottomYB, rightTopXC, rightTopYD);
            var r2 = new Rectangle(leftBottomXE, leftBottomYF, rightTopXG, rightTopYH);
            
            int _case = WhichRelationship(r1, r2);
            if (isReverseRelationship)
            {
                temp = r1;
                r1 = r2;
                r2 = temp;
                isReverseRelationship = false;
            }

            switch (_case)
            {
                case 0:
                    temp = new Rectangle(
                        r2.LeftBottomPoint.X, r1.LeftBottomPoint.Y,
                        r1.RightTopPoint.X, r2.RightTopPoint.Y);
                    return r1.Area + r2.Area - temp.Area;
                case 1:
                    return r1.Area;
                case 2:
                    return r2.Area;
                case 3:
                    return r2.Area;
                case 4:
                    return r1.Area + r2.Area;
                case 5:
                    temp = new Rectangle(
                        r1.RightTopPoint.X, r1.RightTopPoint.Y,
                        r2.LeftBottomPoint.X, r2.LeftBottomPoint.Y);
                    return r1.Area + r2.Area - temp.Area;
                case 6:
                     temp = new Rectangle(
                        r1.LeftTopPoint.X, r1.LeftTopPoint.Y,
                        r2.RightBottomPoint.X, r2.RightBottomPoint.Y);
                     temp = new Rectangle(temp.LeftTopPoint.X, temp.LeftTopPoint.Y,
                        temp.RightBottomPoint.X, temp.RightBottomPoint.Y);

                    return r1.Area + r2.Area - temp.Area;
                case 7:
                    temp = new Rectangle(
                        r1.LeftBottomPoint.X, r1.LeftBottomPoint.Y,
                        r2.RightTopPoint.X, r2.RightTopPoint.Y);
                    return r1.Area + r2.Area - temp.Area;

                case 8:
                    temp = new Rectangle(
                        r1.LeftBottomPoint.X, r1.LeftBottomPoint.Y,
                        r1.RightBottomPoint.X, r2.RightTopPoint.Y);
                    return r1.Area + r2.Area - temp.Area;
                case 9:
                    temp = new Rectangle(
                        r2.LeftBottomPoint.X, r1.RightBottomPoint.Y,
                        r1.RightTopPoint.X, r1.RightTopPoint.Y);
                    return r1.Area + r2.Area - temp.Area;
                case 10:
                    temp = new Rectangle(
                        r1.LeftTopPoint.X, r2.LeftBottomPoint.Y,
                        r1.RightTopPoint.X, r1.RightTopPoint.Y);
                    return r1.Area + r2.Area - temp.Area;
                case 11:
                    temp = new Rectangle(
                        r1.LeftBottomPoint.X, r1.LeftBottomPoint.Y,
                        r2.RightTopPoint.X, r1.RightTopPoint.Y);
                    return r1.Area + r2.Area - temp.Area;
                case 12://
                    temp = new Rectangle(
                        r2.LeftBottomPoint.X, r1.LeftBottomPoint.Y,
                        r2.RightTopPoint.X, r1.RightTopPoint.Y
                        );
                    return r1.Area + r2.Area - temp.Area;
                default:
                    return -1;
            }
        }


        /// <summary>
        /// return value 0:right bottom intersect , 1: r1 contains r2, 2:r2 contains r1,3:Exactly Same
        /// 4: disjoint or tangency 5:right top intersect ,
        /// 6: left top intersect,  7: left bottom intersect.
        /// 8: r2 bottom half contains r1, 9: r2 right half contains r1
        /// 10: r2 top half contains r1, 11: r2 left half contains r1
        /// </summary>
        public int WhichRelationship(Rectangle r1, Rectangle r2)
        {

            int tag = -1;
            // both LB RT not same
            //if (r1.LeftBottomPoint != r2.LeftBottomPoint &&
            //    r1.RightTopPoint != r2.RightTopPoint)
            //{

            //  int sss = r1.RightBottomPoint.CompareTo(r2.RightTopPoint);
            //  int ss2s = r1.LeftBottomPoint.CompareTo(r2.LeftBottomPoint);
            //r1 左下点 大于r2 左下点
            if (r1.LeftBottomPoint.CompareTo(r2.LeftBottomPoint) < 0
                && r1.RightTopPoint.CompareTo(r2.RightTopPoint) > 0)
            {
                tag = 1;
            }
            // both LB RT are same
            else if (r1.LeftBottomPoint == r2.LeftBottomPoint &&
                     r1.RightTopPoint == r2.RightTopPoint)
            {
                tag = 3;
            }

            // only LB Same
            //else if (r1.LeftBottomPoint == r2.LeftBottomPoint)
            //{
            //    if (r1.RightTopPoint.X >= r2.RightTopPoint.X &&
            //        r1.RightTopPoint.Y >= r2.RightTopPoint.Y)
            //    {
            //        tag = 1;
            //    }
            //    //LB Same and include
            //    else if (r1.RightTopPoint.X <= r2.RightTopPoint.X &&
            //             r1.RightTopPoint.Y <= r2.RightTopPoint.Y)
            //    {
            //        tag = 2;
            //    }
            //    else
            //    {
            //        tag = 0;
            //    }
            //}
            //// only RT Same
            //else if (r1.RightTopPoint == r2.RightTopPoint)
            //{
            //    if (r1.LeftBottomPoint.X >= r2.LeftBottomPoint.X &&
            //        r1.LeftBottomPoint.Y >= r2.LeftBottomPoint.Y)
            //    {
            //        tag = 2;
            //    }
            //    //LB Same and include
            //    else if (r1.LeftBottomPoint.X <= r2.LeftBottomPoint.X &&
            //             r1.LeftBottomPoint.Y <= r2.LeftBottomPoint.Y)
            //    {
            //        tag = 1;
            //    }
            //    else
            //    {
            //        tag = 0;
            //    }
            //}

            else if (r1.LeftBottomPoint.CompareTo(r2.LeftBottomPoint) > 0
                     && r1.RightTopPoint.CompareTo(r2.RightTopPoint) < 0)
            {//r2 contains r1
                tag = 2;
            }
            else if (r1.LeftBottomPoint.X >= r2.RightTopPoint.X ||
                     r1.LeftBottomPoint.Y >= r2.RightTopPoint.Y)//disjoint
            {
                tag = 4;
            }
            else if ((r1.RightTopPoint.X <= r2.LeftBottomPoint.X ||
                      r1.RightTopPoint.Y <= r2.LeftBottomPoint.Y))
            {
                tag = 4;
            }
            else if (r1.LeftTopPoint.CompareTo(r2.LeftTopPoint,true) > 0 &&
                     r1.RightBottomPoint.CompareTo(r2.RightBottomPoint, true) > 0)
            {
                tag = 0;
            }
            else if (r2.LeftBottomPoint.CompareTo(r1.LeftBottomPoint) > 0 &&
                     r2.RightTopPoint.CompareTo(r1.RightTopPoint) > 0)
            {
                tag = 5;
            }
            else if (r2.LeftTopPoint.CompareTo(r1.LeftTopPoint, true) > 0 &&
                     r2.RightBottomPoint.CompareTo(r1.RightBottomPoint, true) > 0)
            {
                //  int sss = r2.LeftTopPoint.CompareTo(r1.LeftTopPoint);
                tag = 6;
            }
            else if (r2.RightTopPoint.CompareTo(r1.RightTopPoint)<0 &&
                     r2.LeftBottomPoint.CompareTo(r1.LeftBottomPoint) < 0)
            {
                tag = 7;
            }

            else if (r1.RightBottomPoint.CompareTo(r2.RightTopPoint) < 0 &&
                     r1.LeftBottomPoint.CompareTo(r2.LeftBottomPoint) > 0)
            {
                tag = 8;
            }
            else if (r1.RightTopPoint.CompareTo(r2.RightTopPoint) < 0 &&
                     r1.RightBottomPoint.CompareTo(r2.LeftBottomPoint) > 0)
            {
                tag = 9;
            }
            else if (r1.LeftTopPoint.CompareTo(r2.LeftBottomPoint) > 0 &&
                     r1.RightTopPoint.CompareTo(r2.RightTopPoint) < 0)
            {
                tag = 10;
            }
            else if (r1.LeftTopPoint.CompareTo(r2.RightTopPoint) < 0 &&
                     r1.LeftBottomPoint.CompareTo(r2.LeftBottomPoint) > 0)
            {
                tag = 11;
            }
            else if (r1.RightTopPoint.CompareTo(r2.RightTopPoint, true) < 0 &&
                     r1.LeftBottomPoint.CompareTo(r2.LeftBottomPoint, true) > 0)
            {
                tag = 12;
            }
            else 
            {
                var temp = r1;
                r1 = r2;
                r2 = temp;
                // swap over r1 & r2  than 

                var whichTag = WhichRelationship(r1, r2);
                if (whichTag == 0) return tag;//no result

                isReverseRelationship = true;
                tag = whichTag;
            }
            return tag;
        }




        /// <summary>
        /// 此方法用于计算矩形长,宽,面积.  左下与右上两个点代表一个矩形
        /// </summary>

    }
}
