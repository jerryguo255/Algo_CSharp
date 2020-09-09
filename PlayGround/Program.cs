using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Lib_0108_ConvertSortedArrayToBST;
using TargetSolution = Lib_0145_BinaryTreePostorderTraversal.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;

namespace PlayGround
{


    class Program
    {
        static void Main(string[] args)
        {

            var tos = new ToolSolution();
            var tas = new TargetSolution();


            var t = tos.GetABinaryTreeWithLevelOrderArray(new int?[] { 1, 2, 3, 4, 5, 6, 7 });
            var actual = tas.PostorderTraversal(t);


            Console.ReadLine();

        }


    }


}
