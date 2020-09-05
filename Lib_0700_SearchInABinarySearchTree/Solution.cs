using System;
using System.Collections;
using System.Collections.Generic;
using Lib_0108_ConvertSortedArrayToBST;
using ToolSolution =  Lib_0108_ConvertSortedArrayToBST.Solution;


namespace Lib_0700_SearchInABinarySearchTree
{
    public class Solution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            TreeNode result = null;
            //Recursion(root);

            Stack<TreeNode> st = new Stack<TreeNode>();

            st.Push(root);
            
            while (st.Count !=0)
            {
                var t = st.Pop();
                if (t.val == val)
                {
                    result = t;
                }
                if (t.left !=null)
                {
                    st.Push(t.left);
                }

                if (t.right !=null)
                {
                    st.Push(t.right);
                }
            }



            void Recursion(TreeNode root)
            {
                if (root.val == val)
                {
                    result = root;
                }
                if (root.left != null)
                {
                    Recursion(root.left);
                }

                if (root.right !=null)
                {
                    Recursion(root.right);
                }

            }

            return result;
        }
    }
}
