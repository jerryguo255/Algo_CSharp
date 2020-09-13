using System;
using System.Collections.Generic;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0110_BalancedBinaryTree
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            int GetHeightOfATree(TreeNode root)
            {
                Stack<TreeNode> st = new Stack<TreeNode>();
                TreeNode pointer;
                int height = 0;
                st.Push(root);
                while (st.Count != 0)
                {
                    pointer = st.Pop();
                    if (pointer != null)
                    {
                        height++;
                        st.Push(pointer.left);
                    }
                    else
                    {
                        st.Pop();
                        height--;//----
                    }
                }
                return 0;
            }

            var diff = GetHeightOfATree(root.left) - GetHeightOfATree(root.left);

            return diff > -2 && diff < -2;

            // diff > -2 && diff < -2 ? true : false;
        }
    }
}
