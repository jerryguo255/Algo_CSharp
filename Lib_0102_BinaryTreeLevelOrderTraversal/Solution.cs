using System;
using System.Collections.Generic;
using Lib_0108_ConvertSortedArrayToBST;

namespace Lib_0102_BinaryTreeLevelOrderTraversal
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root ==null)
            {
                return new List<IList<int>>();
            }
            var stA = new Queue<TreeNode>();
            var stB = new Queue<TreeNode>();
            bool isStB = false;
            stA.Enqueue(root);
            TreeNode t;
            IList<IList<int>> result = new List<IList<int>>();
            List<int> alList = new List<int>();



            while (stA.Count != 0 || stB.Count != 0)
            { //if it is stA 
                if (!isStB)
                {    // stA is not empty
                    if (stA.TryDequeue(out t))
                    {//do something
                        if (t!=null)
                        {
                            alList.Add(t.val);
                        
                      
                        //enqueue next level to another Queue stB
                        stB.Enqueue(t.left);
                        stB.Enqueue(t.right);
                        }
                    }
                    else // when stA empty, set flag is stB
                    {
                        isStB = true;
                        result.Add(alList);
                        alList = new List<int>(); 
                    }
                }
                else // if it is stB
                {          // stA is not empty
                    if (stB.TryDequeue(out t))
                    {
                        if (t != null)
                        {
                            alList.Add(t.val);
                        
                        stA.Enqueue(t.left);
                        stA.Enqueue(t.right);
                        }
                    }
                    else
                    {
                        isStB = false;
                        result.Add(alList);
                        alList = new List<int>();
                    }
                }
            }
            return result;
        }
    }
}
