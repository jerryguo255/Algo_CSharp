using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Lib_0108_ConvertSortedArrayToBST;
using TargetSolution = Lib_0617_MergeTwoBinaryTrees.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;

namespace PlayGround
{


    class Program
    {
        static void Main(string[] args)
        {
            var tos = new ToolSolution();
            var tas = new TargetSolution();

            var t1 = tos.GetABinaryTreeWithLevelOrderArray(
                 new int?[] {1,null,1,null,1,null,// 0  1  2  3  4  5
                     1,null,1,null,1,null,// 6  7  8  9  10 11
                     1,null,1,null,1,null,// 12 13 14 15 16 17
                     1,null,1,2 });//18 19 20 21
            var t2 = tos.GetABinaryTreeWithLevelOrderArray(
                new int?[] {1,null,1,null,1,null,
                    1,null,1,null,1,2 });




            //var t1 = tos.GetABinaryTreeWithLevelOrderArray(
            //     new int?[] { 1, 3, 2, 5 });
            //var t2 = tos.GetABinaryTreeWithLevelOrderArray(
            //    new int?[] { 2, 1, 3, null, 4, null, 7 });

            var result =  tas.MergeTrees(t1, t2);
           var rr= tos.ConvertBSTToLevelOrderArray(result);

            Console.ReadLine();
        }

    }


}
