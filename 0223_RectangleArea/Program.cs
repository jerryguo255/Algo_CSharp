using System;

namespace LC_0223_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int ComputeArea(int LeftBottomX_A, int LeftBottomY_B, int RightTopX_C, int RightTopY_D,
            int LeftBottomX_E, int LeftBottomY_F, int RightTopX_G, int RightTopY_H)
        {




            return 0;
        }

        public int ComputeSquareArea(int LeftBottomX, int LeftBottomY, int RightTopX, int RightTopY)
        {
            //1 get the height
            //1.1 RightTop  Y axis   - LeftBottom Y axis
            int height = RightTopY - LeftBottomY;


            //END get the height 



            //2 get the width
            //2.2 RightTop  X axis   - LeftBottom X axis

            int width = RightTopX - LeftBottomX;


            //3 compute the area
            int area = height * width;

            return area;
        }
    }
}
