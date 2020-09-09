using System;
using System.Collections.Generic;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0094_BinaryTreeInorderTraversal
{
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();

            Stack<TreeNode> sq = new Stack<TreeNode>();
            sq.Push(root);

            while (sq.Count != 0)
            {
                var t = sq.Peek();
                if (t != null)
                {
                    sq.Push(t.left);
                }
                else
                {
                    sq.Pop();
                    if (!sq.TryPop(out t)) continue;
                    result.Add(t.val);
                    sq.Push(t.right);
                }
            }

            return result;
        }
    }
}
