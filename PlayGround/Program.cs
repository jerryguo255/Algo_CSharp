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
           var t = tos.GetBinaryTreeWithLevelOrderArray(
              // new int?[] {1, 3,null,null, 2, 5}
                 new int?[] { 2, 1, 3,null,4, null, 7 }

               );

          var arr= tos.ConvertBSTToLevelOrderArray(t);
            Console.ReadLine();
        }

    }


}
