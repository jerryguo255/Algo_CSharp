using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Lib_0108_ConvertSortedArrayToBST;
using TargetSolution = Lib_0110_BalancedBinaryTree.Solution;
using ToolSolution = Lib_0108_ConvertSortedArrayToBST.Solution;

namespace PlayGround
{


    class Program
    {
        static void Main(string[] args)
        {

            var tos = new ToolSolution();
            var tas = new TargetSolution();

           var t= tos.GetABinaryTreeWithLevelOrderArray(new int?[] { 1, 2, null, 3, null, 4, null, 5 });
          
           Console.WriteLine(tas.IsBalanced(t));
            Console.ReadLine();

        }


    }


}
