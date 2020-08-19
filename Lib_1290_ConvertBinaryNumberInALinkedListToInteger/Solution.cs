using System;
using Lib_0021_MergeTwoSortedLists;


namespace Lib_1290_ConvertBinaryNumberInALinkedListToInteger
{
    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            var dummyNode = head;
            var binaryNumber="";
            while (dummyNode.next !=null)
            {
                binaryNumber += dummyNode.val.ToString();
                dummyNode = dummyNode.next;
            }

            if (dummyNode.next != null) return Convert.ToInt32(binaryNumber, 2);
            binaryNumber += dummyNode.val.ToString();
            
            return Convert.ToInt32(binaryNumber, 2);
        }

    }
}
