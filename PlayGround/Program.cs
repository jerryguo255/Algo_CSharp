using System;
using System.Collections.Generic;
using System.Linq;
using ToolSolutin = Lib_0021_MergeTwoSortedLists.Solution;
using TargetSolution = Lib_0092_ReverseLinkedList_II.Solution;


namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new TargetSolution();
            var tools = new ToolSolutin();
            var node = tools.InitWithIntArray(new[] { 1, 2, 3, 4, 5 });//154356
            var result = ts.ReverseBetween(node, 1, 5);

            tools.PrintListNode(result);

        }


    }


}
