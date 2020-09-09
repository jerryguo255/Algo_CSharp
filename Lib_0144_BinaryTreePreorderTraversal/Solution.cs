using System;
using System.Collections.Generic;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0144_BinaryTreePreorderTraversal
{
    public class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            Stack<TreeNode> sq = new Stack<TreeNode>();
            IList<int> ints = new List<int>();
            sq.Push(root);
            
            while (sq.Count !=0)
            {
                var t = sq.Pop();
                if (t !=null)
                {
                    ints.Add(t.val);
                    sq.Push(t.right);
                    sq.Push(t.left);
                    
                }
            }
            return ints;
        }
    }
}
