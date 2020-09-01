using System;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0938_RangeSumOfBST
{
    public class Solution
    {
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            if (root ==null)
            {
                return 0;
            }
            int result = 0;

            void Recursion(TreeNode n)
            {
                if (n.val >=L && n.val<=R) result += n.val;
                if (n.left != null) Recursion(n.left);
                if (n.right != null)  Recursion(n.right);
            }
            Recursion(root);
            return result;
        }
    }
}
