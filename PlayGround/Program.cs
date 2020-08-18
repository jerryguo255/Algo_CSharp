using System;
using System.Collections.Generic;
using System.Linq;
using Lib_0021_MergeTwoSortedLists;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {


            var _solution = new Solution();



            // _solution.InitWithIntArray(new[] {0, 1, 4, 5, 22, 55, 56, 67, 77, 79});


            //var output1 = _solution.MergeTwoLists(
            //    _solution.InitWithIntArray(new[] { 0, 1, 22, 55, 56, 67, 79 }),
            //     _solution.InitWithIntArray(new[] { 4, 5, 77 })
            //     );

            //var output2 = _solution.MergeTwoLists(
            //   _solution.InitWithIntArray(new[] { 4, 5, 66 }),
            //   _solution.InitWithIntArray(new[] { 0, 1, 22, 55, 56, 67, 79 })
            //   );

            var output3 = _solution.MergeTwoLists(
                _solution.InitWithIntArray(new[] { 1 }),
                _solution.InitWithIntArray(new[] { 2 })
            );

            _solution.PrintListNode(output3);


            Console.ReadLine();
        }


    }

   
}
