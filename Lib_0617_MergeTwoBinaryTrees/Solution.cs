using System;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0617_MergeTwoBinaryTrees
{
    public class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            // carend 17:45
            TreeNode result = new TreeNode();
            result.val = t1.val + t2.val;
            var pointer = result;
            void Recursion(TreeNode t1,TreeNode t2)
            {
                if (t1.left !=null && t2.left!=null)
                {
                    pointer.left = new TreeNode(t1.left.val + t2.left.val);
                    pointer = pointer.left;
                    Recursion(t1.left,t2.left);
                } 
                else if (t1.left == null && t2.left != null)
                {
                    pointer.left = new TreeNode( t2.left.val);
                }
                else if (t1.left != null && t2.left == null)
                {
                    pointer.left = new TreeNode(t1.left.val);
                }

                if (t1.right != null && t2.right != null)
                {
                    pointer.right = new TreeNode(t1.right.val + t2.right.val);
                    pointer = pointer.right;
                    Recursion(t1.right, t2.right);
                }
                else if (t1.right == null && t2.right != null)
                {
                    pointer.right = new TreeNode(t2.right.val);
                }
                else if (t1.right != null && t2.right == null)
                {
                    pointer.right = new TreeNode(t1.right.val);
                }

            }

            return result;
        }



        
    }
}
