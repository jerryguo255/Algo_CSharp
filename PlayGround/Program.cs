using System;
using System.Collections.Generic;
using System.Linq;
using Lib_0876_MiddleOfTheLinkedList;
using Lib_0021_MergeTwoSortedLists;


namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {

            var toolSolution = 
                new Lib_0021_MergeTwoSortedLists.Solution();

            
            var solution = new Lib_0876_MiddleOfTheLinkedList.Solution();

            var n1 =toolSolution.InitWithIntArray(new []{ 5, 5, 6,5,6,4,3,2,1 });

           var middled = solution.MiddleNode(n1);

            toolSolution.PrintListNode(middled);

            Console.ReadLine();
        }


    }

   
}
