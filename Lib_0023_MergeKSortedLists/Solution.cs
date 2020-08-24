using System;
using System.Linq;
using Lib_0021_MergeTwoSortedLists;

namespace Lib_0023_MergeKSortedLists
{
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode node = null;
            if (lists ==null|| lists.Length == 0)
                return null;
           
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] == null) continue;
                node = MergeTwoLists(node, lists[i]);
            }

            return node;
        }

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {

            ListNode dummy1 = l1;
            ListNode dummy2 = l2;
            ListNode output = new ListNode();
            ListNode dummyOutput = output;
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            while (dummy1.next != null || dummy2.next != null)
            {
                if (dummy1.val < dummy2.val)
                {
                    if (dummy1.next != null)
                    {
                        dummyOutput.val = dummy1.val;
                        dummy1 = dummy1.next;//pointer move

                        dummyOutput.next = new ListNode();
                        dummyOutput = dummyOutput.next;//pointer move
                    }
                    else
                    {
                        dummyOutput.val = dummy1.val;
                        dummyOutput.next = dummy2;  //end of dummy , splicing another dummy directly
                        break;
                    }
                }

                else
                {
                    if (dummy2.next != null)
                    {
                        dummyOutput.val = dummy2.val;
                        dummy2 = dummy2.next;

                        dummyOutput.next = new ListNode();
                        dummyOutput = dummyOutput.next;
                    }
                    else
                    {
                        dummyOutput.val = dummy2.val;
                        dummyOutput.next = dummy1;  //end of dummy , splicing dummy2 directly
                        break;
                    };
                }
            }

            if (dummy1.val < dummy2.val)
            {
                dummyOutput.val = dummy1.val;
                dummyOutput.next = dummy2;
            }
            else
            {
                dummyOutput.val = dummy2.val;
                dummyOutput.next = dummy1;
            }



            return output;
        }

    }
}
