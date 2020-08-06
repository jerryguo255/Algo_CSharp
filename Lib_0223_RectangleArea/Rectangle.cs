namespace Lib_0223_RectangleArea
{
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
            return LeftBottomPoint.CompareTo(other.RightTopPoint,0) < 0
                   && RightTopPoint.CompareTo(other.LeftBottomPoint,0) > 0 
                   ||
                   RightBottomPoint.CompareTo(other.LeftTopPoint,0) < 0
                   && LeftTopPoint.CompareTo(other.RightBottomPoint,0) > 0;
        }
    }
}