using System;
using System.Collections.Generic;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0110_BalancedBinaryTree
{
    public class Solution
    {
        public bool IsBalanced(TreeNode root)
        {
            bool result = true;
            if (root != null)
            {
                var nodes = GetNodesOfATree(root);
                #region v1 check all the nodes, need to be optimize

                //foreach (var node in nodes)
                //{
                //    if (!IsBalancedNode(node))
                //    {
                //        result = false;
                //    }
                //}
                #endregion

                #region v2 only check nodes above depth -2
                //get depth of the tree
                var height = GetHeightOfATree(root);
                //work out how many node level it have,  ( Two to the level-1 power 2^i-1) (0 base)
                var ignoreNodesIndex = Math.Pow(2, height) + Math.Pow(2, height - 1) - 1;

                //if ignored Nodes number over 80% of all nodes , means too much null nodes.
                if (ignoreNodesIndex > nodes.Count*0.8)
                {//traversal all nodes
                    foreach (var node in nodes)
                    {
                        if (!IsBalancedNode(node))
                        {
                            result = false;
                        }
                    }
                }else {
                    //traversal all nodes excepted last two level
                    for (int i = 0; i < nodes.Count - ignoreNodesIndex; i++)
                    {
                        if (!IsBalancedNode(nodes[i]))
                        {
                            result = false;
                        }
                    }
                }
                

                #endregion
            }
            return result;


            int GetHeightOfATree(TreeNode root)
            {
                var stA = new Queue<TreeNode>();
                var stB = new Queue<TreeNode>();

                TreeNode pointer;
                int height = -1;
                stA.Enqueue(root);
                bool isStb = false;
                while (stA.Count != 0 || stB.Count != 0)
                {
                    if (!isStb)
                    {// stA
                        if (stA.TryDequeue(out pointer))
                        {
                            if (pointer == null) continue;
                            stB.Enqueue(pointer.left);
                            stB.Enqueue(pointer.right);
                        }
                        else
                        {
                            isStb = true;
                            height++;
                        }
                    }
                    else
                    {// stB
                        if (stB.TryDequeue(out pointer))
                        {
                            if (pointer == null) continue;
                            stA.Enqueue(pointer.left);
                            stA.Enqueue(pointer.right);
                        }
                        else
                        {
                            isStb = false;
                            height++;
                        }
                    }

                    //if (pointer != null)
                    //{
                    //    height++;
                    //    st.Push(pointer.left);
                    //}
                    //else
                    //{
                    //    st.Pop();
                    //    height--;//----
                    //}
                }
                return height;
            }

            List<TreeNode> GetNodesOfATree(TreeNode root)
            {
                var stA = new Queue<TreeNode>();
                var stB = new Queue<TreeNode>();
                List<TreeNode> nodes = new List<TreeNode>();
                TreeNode pointer;
                int height = -1;
                stA.Enqueue(root);
                bool isStb = false;
                while (stA.Count != 0 || stB.Count != 0)
                {
                    if (!isStb)
                    {// stA
                        if (stA.TryDequeue(out pointer))
                        {
                            nodes.Add(pointer);
                            //only add non-empty elememt
                            if (pointer == null) continue;
                            stB.Enqueue(pointer.left);
                            stB.Enqueue(pointer.right);


                            ////complete tree with null elements
                            //if (pointer != null)
                            //{
                            //    stB.Enqueue(pointer.left);
                            //    stB.Enqueue(pointer.right);
                            //}
                            //else
                            //{
                            //    stB.Enqueue(null);
                            //    stB.Enqueue(null);
                            //}

                        }
                        else
                        {
                            isStb = true;
                            height++;
                        }
                    }
                    else
                    {// stB
                        if (stB.TryDequeue(out pointer))
                        {
                            nodes.Add(pointer);
                            //only add non-empty elememt
                            if (pointer == null) continue;
                            stA.Enqueue(pointer.left);
                            stA.Enqueue(pointer.right);


                            ////complete tree with null elements
                            //if (pointer != null)
                            //{
                            //    stA.Enqueue(pointer.left);
                            //    stA.Enqueue(pointer.right);
                            //}
                            //else
                            //{
                            //    stA.Enqueue(null);
                            //    stA.Enqueue(null);
                            //}

                           
                        }
                        else
                        {
                            isStb = false;
                            height++;
                        }
                    }

                    //if (pointer != null)
                    //{
                    //    height++;
                    //    st.Push(pointer.left);
                    //}
                    //else
                    //{
                    //    st.Pop();
                    //    height--;//----
                    //}
                }
                return nodes;
            }

            bool IsBalancedNode(TreeNode node)
            {
                if (node != null)
                {
                    var aHeight = GetHeightOfATree(node.left);
                    var bHeight = GetHeightOfATree(node.right);
                    return aHeight - bHeight > -2 && aHeight - bHeight < 2;
                }

                return true;
            }
            // diff > -2 && diff < -2 ? true : false;
        }

        /// <summary>
        /// from discuss area
        /// https://leetcode.com/problems/balanced-binary-tree/discuss/36008/A-Iterative-PostOrder-Traversal-Java-Solution
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool JavaIsBalanced(TreeNode root)
        {
            if (root == null) return true;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var map = new Dictionary<TreeNode,int>();
            stack.Push(root);
            while (stack.Count !=0)
            {
                TreeNode node = stack.Pop();
                if ((node.left == null || node.left != null && map.ContainsKey(node.left)) 
                    && (node.right == null || node.right != null && map.ContainsKey(node.right)))
                {
                    int left = node.left == null ? 0 : map[node.left];
                    int right = node.right == null ? 0 : map[node.right];
                    if (Math.Abs(left - right) > 1) return false;
                    map.Add(node, Math.Max(left, right) + 1);
                }
                else
                {
                    if (node.left != null && !map.ContainsKey(node.left))
                    {
                        stack.Push(node);
                        stack.Push(node.left);
                    }
                    else
                    {
                        stack.Push(node);
                        stack.Push(node.right);
                    }
                }
            }
            return true;
        }


    }
}
