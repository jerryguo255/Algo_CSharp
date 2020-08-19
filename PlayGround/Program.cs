using System;
using System.Collections.Generic;
using System.Linq;
using Lib_0206_ReverseLinkedList;
using Lib_0021_MergeTwoSortedLists;


namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {

            var toolSolution = 
                new Lib_0021_MergeTwoSortedLists.Solution();

            
            var solution = new Lib_0206_ReverseLinkedList.Solution();

            var n1 =toolSolution.InitWithIntArray(new []{ 5,4,3,2,1 });
            var n2 =solution.ReverseList(toolSolution.InitWithIntArray(new[] { 1, 2, 3, 4, 5 }));


            Console.ReadLine();
        }


    }

   
}
