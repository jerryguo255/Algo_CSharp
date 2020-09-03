using System;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0617_MergeTwoBinaryTrees
{
    public class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            

            TreeNode Recursion(TreeNode t1, TreeNode t2)
            {
                TreeNode result =null;

                if (t1 !=null && t2 != null)
                {
                    result = new TreeNode(t1.val + t2.val);
                   result.left = Recursion(t1.left, t2.left);
                    result.right = Recursion(t1.right, t2.right);
                }
                else if (t1 == null && t2 != null)
                {
                    result = new TreeNode(t2.val);
                    result.left = Recursion(null, t2.left);
                    result.right = Recursion(null, t2.right);
                }
                else if (t1 != null && t2 == null)
                {
                    result = new TreeNode(t1.val);
                    result.left = Recursion(t1.left, null);
                    result.right = Recursion(t1.right, null);
                }

                return result;
            }

            var r = Recursion(t1, t2);

            return r; 

            #region first try




            //if (t1==null && t2==null)
            //{
            //    return null;
            //}

            //TreeNode root = new TreeNode();

            //if (t1==null)
            //{
            //    root.val = t2.val;
            //    return root;
            //}
            //if (t2 == null)
            //{
            //    root.val = t1.val;
            //    return root;
            //}
            //root.val = t1.val + t2.val;
            //var pointer = root;
            //var previousPointer = pointer;
            //int recursionLevel = 0;
            //Recursion(t1,t2);

            //void Recursion(TreeNode t1,TreeNode t2)
            //{
            //    if (t1 !=null && t2 !=null )
            //    {
            //        if (t1.left != null && t2.left != null)
            //        {
            //            pointer.left = new TreeNode(t1.left.val + t2.left.val);
            //            previousPointer = pointer;
            //            pointer = pointer.left;
            //            recursionLevel++;
            //            Recursion(t1.left, t2.left);
            //            recursionLevel--;
            //            if (recursionLevel==0)
            //            {
            //                pointer = root;
            //            }
            //            else
            //            {
            //                pointer = previousPointer; //***
            //            }
            //            //when finished left recursion, reset the point to root node

            //        }
            //        else if (t1.left == null && t2.left != null)
            //        {
            //            pointer.left = new TreeNode(t2.left.val);
            //            previousPointer = pointer;
            //            pointer = pointer.left;
            //            Recursion(t1.left, t2.left);
            //            //when finished sub recursion, reset the point to previous node
            //            pointer = previousPointer; 
            //        }
            //        else if (t1.left != null && t2.left == null)
            //        {
            //            pointer.left = new TreeNode(t1.left.val);
            //            previousPointer = pointer;
            //            pointer = pointer.left;
            //            Recursion(t1.left, t2.left);
            //            //when finished sub recursion, reset the point to previous node
            //            pointer = previousPointer; 
            //        }

            //        if (t1.right != null && t2.right != null)
            //        {
            //            pointer.right = new TreeNode(t1.right.val + t2.right.val);
            //            pointer = pointer.right;
            //            Recursion(t1.right, t2.right);
            //        }
            //        else if (t1.right == null && t2.right != null)
            //        {
            //            pointer.right = new TreeNode(t2.right.val);
            //            pointer = pointer.right;
            //            Recursion(t1.right, t2.right);
            //        }
            //        else if (t1.right != null && t2.right == null)
            //        {
            //            pointer.right = new TreeNode(t1.right.val);
            //            pointer = pointer.right;
            //            Recursion(t1.right, t2.right);
            //        }

            //    } else if (t1== null && t2 != null)
            //    {
            //        if (t2.left !=null)
            //        {
            //            pointer.left = new TreeNode(t2.left.val);
            //        }

            //        if (t2.right !=null)
            //        {
            //            pointer.right = new TreeNode(t2.right.val);
            //        }
            //    }
            //    else if (t1 != null && t2 == null)
            //    {
            //        if (t1.left != null)
            //        {
            //            pointer.left = new TreeNode(t1.left.val);
            //        }
            //        if (t1.right != null)
            //        {
            //            pointer.right = new TreeNode(t1.right.val);
            //        }
            //    }


            //}
            //return root;

            #endregion
        }
    }
}
