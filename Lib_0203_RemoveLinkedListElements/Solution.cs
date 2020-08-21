using System;

using Lib_0021_MergeTwoSortedLists;

namespace Lib_0203_RemoveLinkedListElements
{
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;

            //only one node
            if (head.next == null)
            {   
                //is the target
                if (head.val == val)
                    return null;
            }

            // now, head >= 2 nodes;


            //check if first few nodes are target node
            while (head != null && head.val == val)
            {
                if (head.next!=null) //1,1,1,2
                    head = head.next;
                else return null;// all nodes are target node
            }

            // now the first of head node is not target;

            //set a pointer call dummyHead
            var dummyHead = head;

            //while next node is not null
            while (dummyHead.next != null) //2,3,4,1    2,1,1,1,1,3,4   
            {
                //next node to the pointer is not the target
                if (dummyHead.next.val !=val)
                    //pointer moves
                    dummyHead = dummyHead.next;
                else //next node is the target
                {
                    //check the following node if is null
                    if (dummyHead.next.next==null)
                        //if null, remove the next , than jump out of while loop
                        dummyHead.next = null;
                    else
                        //remove the target node,
                        dummyHead.next = dummyHead.next.next;
                }
            }
          




            //while ( dummyHead?.next!=null)
            //{//while 
            //    if (head.val == val)
            //    {//if the first node is target node, than get rid of it,
            //        head = dummyHead = dummyHead.next;
            //        if (dummyHead.next==null&&dummyHead.val==val)
            //            return null;
            //    }
            //    else
            //    {
            //        if (dummyHead.next.val==val)
            //        {

            //            dummyHead.next = dummyHead.next.next;

            //            //if (dummyHead.next.next != null)
            //            //{
            //            //    //delete the node
            //            //    dummyHead.next = dummyHead.next.next;
            //            //    if (dummyHead.next.val == val)
            //            //    {//if the last node equal val
            //            //        dummyHead.next = null;
            //            //        //  return head;
            //            //    }
            //            //}
            //            //else
            //            //    dummyHead.next = null;
            //        }
            //        dummyHead = dummyHead.next;
            //    }
            //}
            return head;
        }
    }
}
