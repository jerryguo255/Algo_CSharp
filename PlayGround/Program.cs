using System;
using Lib_0223_RectangleArea;
namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var l0223 = new Lib_0223_RectangleArea.Lib_0223_RectangleArea();
           // var result1 = l0223.ComputeTotalArea(-2, -2,
            //    2, 2, -3, 1, -1, 3);



            var result2 = l0223.ComputeArea(-3,-3,5,0,-3,-3,3,3);
           

            Console.WriteLine(result2);
            //  var exceptedRectangle = new Rectangle(0, 0, 3, 2);
            Console.ReadLine();
        }   
       

    }
}
