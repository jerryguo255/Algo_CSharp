using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Lib_0108_ConvertSortedArrayToBST;
using TargetSolution = Lib_0700_SearchInABinarySearchTree.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;

namespace PlayGround
{


    class Program
    {
        static void Main(string[] args)
        {

            var tos = new ToolSolution();
            var tas = new TargetSolution();

         var root=   tos.GetABinaryTreeWithLevelOrderArray(new int?[] {4, 2, 7, 1, 3});

         var result= tas.SearchBST(root,2);
        var rarr= tos.ConvertBSTToLevelOrderArray(result);


            Console.ReadLine();
                
        }


    }


}
