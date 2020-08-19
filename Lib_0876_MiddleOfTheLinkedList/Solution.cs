using System;
using Lib_0021_MergeTwoSortedLists;

namespace Lib_0876_MiddleOfTheLinkedList
{
    /// <summary>
    /// #Recursive version
    /// </summary>
    public class Solution
    {
        private int _counter=1;
        private int _mid;
        private ListNode _resultNode;

        public ListNode MiddleNode(ListNode head)
        {
            if (head != null)
            {
                if (head.next == null)
                {
                    if (_counter==1) return head;
                    _mid = _counter / 2;
                    _counter--;
                }
                else
                {
                    _counter++;
                    MiddleNode(head.next);
                    _counter--;
                }
                if (_counter == _mid)
                    _resultNode = head;
            }
            return _resultNode;
        }
    }
}
