using System;
using System.Collections.Generic;
using Lib_0021_MergeTwoSortedLists;

namespace Lib_0206_ReverseLinkedList
{
    /// <summary>
    /// 递归需要注意的点：
    /// 递归开始触发的时候， 需要带上初始数据
    /// 控制递归的结束条件，
    /// 递归尾部的循环次数
    /// 返回递归头部的循环次数以及来回总次数
    /// 用循环次数控制并保留最后的数据
    /// </summary>
    public class Solution
    {
        
        private ListNode _resultNode;
        private ListNode _dummyResultNode ;
        private int counter;

        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
           
            if (head.next == null) //the right point of recursion
            {
                if (counter == 0)
                {
                    return head;
                }
                _resultNode = head;
                _resultNode.next = new ListNode(int.MaxValue);
                _dummyResultNode = _resultNode;
                
            }
            else
            {
                //============  area of a recursion when going into ========

                counter++;//count total recursion times


                //============  area of a recursion when going into ========
                ReverseList(head.next);


                //============ area of a recursion when going out ========
                _dummyResultNode.next.val = head.val;
                _dummyResultNode = _dummyResultNode.next;
                counter--;//when total recursion times equals zero

                if (counter!=0)// not at the tail yet
                {
                    _dummyResultNode.next = new ListNode(-1);
                }else if (counter == 0) // reach the end
                {
                    return _resultNode;
                }
                //============ area of a recursion when going out ========
            }
            return head;
        }
    }
}
