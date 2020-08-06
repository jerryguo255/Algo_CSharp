using System;



namespace Lib_0836_RectangleOverlap
{
    /// <summary>
    /// A rectangle is represented as a list [x1, y1, x2, y2], where (x1, y1) are the coordinates of
    /// its bottom-left corner, and (x2, y2) are the coordinates of its top-right corner.
    /// Two rectangles overlap if the area of their intersection is positive.To be clear,
    /// two rectangles that only touch at the corner or edges do not overlap.
    /// Given two (axis-aligned) rectangles, return whether they overlap.
    /// </summary>
    public class Solution
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {


            var r1 = new Rectangle(rec1[0],rec1[1],rec1[2],rec1[3]);
            var r2 = new Rectangle(rec2[0], rec2[1], rec2[2], rec2[3]);


            
            return r1.IsOverlap(r2);
        }
       
    }


    public class RPoint : IComparable<RPoint>, IEquatable<RPoint>
    {
        public int X { get; }
        public int Y { get; }

        public RPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X:{X} Y:{Y}";
        }


        /// <summary>
        /// rightTop to leftBottom , great to less,
        /// if one of both point's comparison = 0, then compare another,
        /// if both point's comparison not equal and not 0, then return 0
        /// </summary>
        /// <param name="other"></param>
        /// <returns>0 means same or invalid, -1 means this point lo</returns>
        public int CompareTo(RPoint other)
        {
            var xComparison = X.CompareTo(other.X);
            var yComparison = Y.CompareTo(other.Y);

            if (xComparison == 0)
            {
                return Y.CompareTo(other.Y);
            }
            if (yComparison == 0)
            {
                return X.CompareTo(other.X);
            }
            if (xComparison != yComparison)
            {
                return 0;
            }

            return xComparison;
        }

        /// <summary>
        /// LeftTop To RightBottom , great to less
        /// if one of both point's comparison = 0, then compare another,
        /// if both point's comparison not equal and not 0, then return 0
        /// </summary>
        /// <param name="other"></param>
        /// <param name="isLeftTopToRightBottom"></param>
        /// <returns></returns>
        public int CompareTo(RPoint other, bool isLeftTopToRightBottom)
        {
            var xComparison = X.CompareTo(other.X);
            var yComparison = Y.CompareTo(other.Y);
            if (!isLeftTopToRightBottom) return 0;
            if (xComparison == 0) return Y.CompareTo(other.Y);

            if (yComparison == 0) return X.CompareTo(other.X) * -1;

            if (xComparison == yComparison) return 0;

            if (xComparison > 0 && yComparison < 0) return -1;

            if (xComparison < 0 && yComparison > 0) return 1;

            return 0;
        }



        /// <summary>
        /// flag 0 : rightTop to leftBottom , great to less,
        /// flag 1:   LeftTop To RightBottom , great to less
        /// ###if there is one of both point's comparison = 0, then return zero###,
        /// </summary>
        /// <param name="other"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public int CompareTo(RPoint other, byte flag)
        {
            var xComparison = X.CompareTo(other.X);
            var yComparison = Y.CompareTo(other.Y);
            if (flag == 0)
            {
                if (xComparison == 0 || yComparison == 0)
                {
                    return 0;
                }

                if (xComparison != yComparison)
                {
                    return 0;
                }


                return xComparison;
            }

            if (flag == 1)
            {

                if (xComparison == 0 || yComparison == 0) return 0;



                if (xComparison == yComparison) return 0;

                if (xComparison > 0 && yComparison < 0) return -1;

                if (xComparison < 0 && yComparison > 0) return 1;


            }

            return 0;


        }

        public override bool Equals(object obj)
        {
            return obj is RPoint other && Equals(other);
        }


        public bool Equals(RPoint other)
        {
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }



        public static bool operator ==(RPoint lhs, RPoint rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(RPoint lhs, RPoint rhs)
        {
            return !lhs.Equals(rhs);
        }
    }

    public class Rectangle
    {
        public RPoint LeftBottomPoint { get; set; }
        public RPoint RightTopPoint { get; set; }

        public RPoint LeftTopPoint { get; set; }
        public RPoint RightBottomPoint { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }
        public int Area { get; set; }

        //public static bool operator >(Rectangle lhs, Rectangle rhs)
        //    => lhs.Area > rhs.Area;


        //public static bool operator <(Rectangle lhs, Rectangle rhs)
        //    => lhs.Area < rhs.Area;

        public Rectangle(int leftBottomX, int leftBottomY, int rightTopX, int rightTopY)
        {
            LeftBottomPoint = new RPoint(leftBottomX, leftBottomY);
            RightTopPoint = new RPoint(rightTopX, rightTopY);


            //Height =  RightTop Y axis - LeftBottom Y axis
            Height = rightTopY - leftBottomY;


            //Width = RightTop X axis - LeftBottom X axis
            Width = rightTopX - leftBottomX;

            //compute the area
            Area = Height * Width;

            LeftTopPoint = new RPoint(leftBottomX, rightTopY);
            RightBottomPoint = new RPoint(rightTopX, leftBottomY);
        }



        /// <summary>
        /// Two rectangles overlap if the area of their intersection is positive,two rectangles that only touch at the corner or edges do not overlap.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool IsOverlap(Rectangle other)
        {
            return LeftBottomPoint.CompareTo(other.RightTopPoint, 0) < 0
                   && RightTopPoint.CompareTo(other.LeftBottomPoint, 0) > 0
                   ||
                   RightBottomPoint.CompareTo(other.LeftTopPoint, 0) < 0
                   && LeftTopPoint.CompareTo(other.RightBottomPoint, 0) > 0;
        }
    }
}
