using System;
using System.Collections;
using System.Collections.Generic;
using Lib_0021_MergeTwoSortedLists;

namespace Lib_0092_ReverseLinkedList_II
{
    public class Solution
    {
        /// <summary>
        /// Reverse a linked list from position m to n. Do it in one-pass.
        ///Note: 1 ≤ m ≤ n ≤ length of list.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        ///
        private int _counter = 0;
        Queue<int> numQ = new Queue<int>();
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head != null)//if head is null,return directly 
            {
                //set up a counter to count the number of recursions
                //each add, the counter equal the position of the linked list(base 1)
                _counter++;

                // check if it is a end node, if not
                if (head.next != null)
                {
                    //check the position in the range
                    if (_counter >= m && _counter <= n)
                    {   //add to a queue
                        numQ.Enqueue(head.val);
                    }
                    //====↑↑↑↑↑ above area is going deep into the recursion
                    //(Left-most to right-most of the linked list)
                    ReverseBetween(head.next, m, n);
                    //====↓↓↓↓↓ following area is getting out of the recursion====
                    //(right-most to Left-most of the linked list)

                    //check the current node if it's in the range
                    if (_counter <= n && _counter >= m)
                    {//if it's in the range, get the first node(dequeue),
                     //swap it with the right-most position node 
                     //dequeue, is first in last out,
                     //so this line of code will reverse order within the range
                        head.val = numQ.Dequeue();
                    }

                    //move back(right to left)
                    _counter--;
                }
                // if it's end node
                else
                {   //check the last node if it's in the range
                    if (_counter >= m && _counter <= n)
                    {//if yes, add into queue
                        numQ.Enqueue(head.val);
                        //meanwhile , dequeue the first node and swap it,
                        head.val = numQ.Dequeue();
                    }

                    //if the last node is not in the range, do nothing


                    //move the position back
                    _counter--;
                }
            }
            return head;
        }
    }
}
