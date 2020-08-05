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

            LeftTopPoint = new RPoint( leftBottomX, rightTopY); 
            RightBottomPoint = new RPoint(rightTopX, leftBottomY); 
        }

    }
}