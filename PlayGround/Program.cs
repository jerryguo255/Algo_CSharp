using System;
using System.Collections.Generic;
using System.Linq;
using Lib_0283_MoveZeroes;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var nums1 = new[] { 1, 2, 0, 3, 0, 4, 0,5,6 };

            var nums2 = new[] {0, 1, 0, 3, 12};
            s.MoveZeroes(nums1);

            foreach (var VARIABLE in nums1)
            {
                Console.Write(VARIABLE+",");
            }
           
            Console.ReadLine();
        }

       
    }
}
