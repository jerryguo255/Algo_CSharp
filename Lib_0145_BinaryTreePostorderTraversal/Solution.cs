using System;
using System.Collections.Generic;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0145_BinaryTreePostorderTraversal
{
    public class Solution
    {
        enum NodeStatus
        {
            Beginning,LeftAlreadyClear,BothClear
        }
        

    public IList<int> PostorderTraversal(TreeNode root)
        {

            
            List<int> result = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();
            var temp = root;
            var nodeStatus = NodeStatus.Beginning;
            st.Push(root);

            while (st.Count != 0)
            {
                temp = st.Peek();

                if (temp != null)
                {
                    if (nodeStatus == NodeStatus.Beginning)
                    {
                        st.Push(temp.left);
                    }
                    else if (nodeStatus == NodeStatus.LeftAlreadyClear)
                    {
                        st.Push(temp.right);
                        
                    }
                    else if (nodeStatus == NodeStatus.BothClear)
                    {
                        //st.Push(temp.right);
                    }
                }
                else
                {
                    st.Pop();
                    temp = st.Peek();

                    if (temp.right !=null)
                    {
                        st.Push(temp.right);
                    }
                    else
                    {
                        result.Add(st.Pop().val);
                        TreeNode tt;
                        if (nodeStatus == NodeStatus.Beginning)
                        {
                            if (st.TryPeek(out tt))
                            {
                                tt.left = null;
                                nodeStatus = NodeStatus.LeftAlreadyClear;
                            }
                            
                        }else if (nodeStatus == NodeStatus.LeftAlreadyClear)
                        {
                            if (st.TryPeek(out tt))
                            {
                                tt.right = null;
                                nodeStatus = NodeStatus.BothClear;
                            }
                        }
                       
                    }
                    
                    //temp.left = null; 
                }
            }
            return result;
        }
    }
}
