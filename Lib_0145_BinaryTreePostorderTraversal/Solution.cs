using System;
using System.Collections.Generic;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0145_BinaryTreePostorderTraversal
{
    public class Solution
    {
        public enum NodeStatus
        {
            Beginning, LeftAlreadyClear, BothClear
        }

        /// <summary>
        /// TNF stands for Tree Node With Flag
        /// </summary>
        public class TNF
        {
            public TreeNode Node { get; }
            public NodeStatus Status { get; set; }

            public TNF(TreeNode node)
            {
                Node = node;
                Status = NodeStatus.Beginning;
            }

        }
        public IList<int> PostorderTraversal(TreeNode root)
        {
            
            if (root ==null)
            {
                return new List<int>();
            }
            List<int> result = new List<int>();
            Stack<TNF> st = new Stack<TNF>();
            var temp = new TNF(root);
            st.Push(temp);

            while (st.Count != 0)
            {
                temp = st.Peek();
                if (temp.Status == NodeStatus.Beginning)
                {
                    if (temp.Node != null)
                    {
                        st.Push(new TNF(temp.Node.left));
                    }
                    //if left is null
                    else
                    {
                        st.Pop(); //get rid of empty left node
                                  //set status for the root of subtree
                        var subRoot = st.Peek();
                        if (subRoot.Status == NodeStatus.Beginning)
                        {
                            subRoot.Status = NodeStatus.LeftAlreadyClear;
                        }
                        else if (subRoot.Status == NodeStatus.LeftAlreadyClear)
                        {
                            subRoot.Status = NodeStatus.BothClear;
                        }
                    }
                }
                else if (temp.Status == NodeStatus.LeftAlreadyClear)
                {
                    st.Push(new TNF(temp.Node.right));
                }
                else if (temp.Status == NodeStatus.BothClear)
                {
                    result.Add(st.Pop().Node.val);
                    TNF subRoot;
                    if (st.TryPeek(out subRoot))
                    {
                        if (subRoot.Status == NodeStatus.Beginning)
                        {
                            subRoot.Status = NodeStatus.LeftAlreadyClear;
                        }
                        else if (subRoot.Status == NodeStatus.LeftAlreadyClear)
                        {
                            subRoot.Status = NodeStatus.BothClear;
                        }
                    }
                }

                #region first try

                //if (temp.Node != null)
                //{
                //    if (temp.Status == NodeStatus.Beginning)
                //    {
                //        st.Push(new TNF(temp.Node.left));
                //    }
                //    else if (temp.Status == NodeStatus.LeftAlreadyClear)
                //    {
                //        st.Push(new TNF(temp.Node.right));

                //    }
                //    else if (temp.Status == NodeStatus.BothClear)
                //    {
                //        //st.Push(temp.right);
                //    }
                //}
                //else
                //{
                //    st.Pop();
                //    temp = st.Peek();
                //    if (temp.Status == NodeStatus.Beginning )
                //    {
                //        temp.Status = NodeStatus.LeftAlreadyClear;
                //        if (temp.Node.right != null)
                //        {
                //            st.Push(new TNF(temp.Node.right));
                //        }
                //        else
                //        {
                //            temp.Status = NodeStatus.BothClear;
                //        }
                //    }
                //    else
                //    {

                //        result.Add(st.Pop().val);
                //        TreeNode tt;
                //        if (nodeStatus == NodeStatus.Beginning)
                //        {
                //            if (st.TryPeek(out tt))
                //            {
                //                tt.left = null;
                //                nodeStatus = NodeStatus.LeftAlreadyClear;
                //            }

                //        }else if (nodeStatus == NodeStatus.LeftAlreadyClear)
                //        {
                //            if (st.TryPeek(out tt))
                //            {
                //                tt.right = null;
                //                nodeStatus = NodeStatus.BothClear;
                //            }
                //        }

                //    }

                //temp.left = null; 

                #endregion

            }
            return result;


        }


        /// <summary>
        /// result of the Right first PreOrder Traversal , then Reverse the result
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> PostorderTraversalFromDiscussBoard(TreeNode root)
        {
            
            List<int> result = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();
            TreeNode p = root;
            while (st.Count !=0 || p!=null)
            {
                if (p!=null)
                {
                    st.Push(p);
                    result.Add(p.val);
                    p = p.right;
                }
                else
                {
                    TreeNode node = st.Pop();
                    p = node.left;
                }
            }

            result.Reverse();
            return result;
        }
    }
}
