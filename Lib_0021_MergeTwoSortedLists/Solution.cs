using System;

namespace Lib_0021_MergeTwoSortedLists
{
    public class Solution
    {
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
                        dummyOutput.next =dummy2;  //end of dummy , splicing another dummy directly
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

            if (dummy1.val<dummy2.val)
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


        /// <summary>
        /// https://leetcode.com/problems/merge-two-sorted-lists/discuss/188108/C-recursive-solution
        ///     #recursive
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode MergeTwoListsRecursive(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            var tmp1 = l1.next;
            var tmp2 = l2.next;
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoListsRecursive(tmp1, l2);

                return l1;
            }

            l2.next = MergeTwoListsRecursive(l1, tmp2);
            return l2;
        }



        /// <summary>
        /// Convert a Int Array to a Single Linked List
        /// </summary>
        /// <param name="numbers">an array of int</param>
        /// <returns></returns>

        public ListNode InitWithIntArray(int[] numbers)
        {
            var l1 = new ListNode { val = numbers[0] };
            var dummyNode = l1;
            for (var i = 1; i < numbers.Length; i++)
            {
                dummyNode.next = new ListNode(numbers[i]);
                dummyNode = dummyNode.next;
            }
            return l1;
        }




        public void PrintListNode(ListNode listNode)
        {

            var dummy = listNode;

            //if only one node
            if (dummy.next == null)
                Console.WriteLine(dummy.val);
            while (dummy.next != null)
            {
                Console.WriteLine(dummy.val);
                dummy = dummy.next;
                if (dummy.next == null)
                    Console.WriteLine(dummy.val);
            }
        }
        public int[] OutputArray(ListNode l)
        {
            var count = 1;
            var dummyNode = l;
            while (dummyNode.next != null)
            {
                dummyNode = dummyNode.next;
                count++;
            }

            int[] output = new int[count];

            dummyNode = l;
            var index = 0;
            //output[index] = dummyNode.val;
            while (dummyNode.next != null)
            {
                output[index] = dummyNode.val;
                index++;
                dummyNode = dummyNode.next;
                if (dummyNode.next == null)
                    output[index] = dummyNode.val;
            }
            return output;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
