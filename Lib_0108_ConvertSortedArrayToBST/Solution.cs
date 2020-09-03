using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lib_0108_ConvertSortedArrayToBST
{


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }



    /// <summary>
    ///   BST == Balanced Complete Binary Search Tree;
    /// </summary>
    public class Solution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums">Sorted Array</param>
        /// <returns></returns>
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null)
            {
                return null;
            }
            if (nums.Length == 0)
            {
                return null;
            }
            
            TreeNode tn;

            if (nums.Length == 3)
            {
                tn = new TreeNode(nums[1]);// middle : 20 length: 40
                tn.left = new TreeNode(nums[0]);
                tn.right = new TreeNode(nums[2]);
                return tn;
            }
            if (nums.Length == 2)
            {
                tn = new TreeNode(nums[1]);
                tn.left = new TreeNode(nums[0]);
                return tn;
            }
            if (nums.Length == 1)
            {
                tn = new TreeNode(nums[0]);
                return tn;
            }
            var middle = nums.Length / 2;
            tn = new TreeNode(nums[middle]);// middle : 20 length: 40
            int[] leftArr;
            int[] rightArr;
            if (nums.Length % 2 == 0)
            {
                leftArr = new int[middle];
                rightArr = new int[middle - 1];

                int j = middle + 1;
                for (int i = 0; i < middle; i++)
                {
                    leftArr[i] = nums[i];
                    if (j != nums.Length)
                    {
                        rightArr[i] = nums[j];
                    }
                    j++;
                }
            }
            else
            {
                leftArr = new int[middle];
                rightArr = new int[middle];

                int j = middle+1;
                for (int i = 0; i < middle; i++)
                {
                    leftArr[i] = nums[i];
                    if (j != nums.Length)
                    {
                        rightArr[i] = nums[j];
                    }
                    j++;
                }
            }

            tn.left = SortedArrayToBST(leftArr);
            tn.right = SortedArrayToBST(rightArr);


            return tn;

        }
        
        public int?[] ConvertBSTToLevelOrderArray(TreeNode tn)
        {
            var result = new List<int?> {tn.val};
            var q = new Queue<TreeNode>();


            q.Enqueue(tn);

            while (q.Count != 0)
            {
                var t = q.Dequeue();
                if (t.left ==null)
                {
                    if (t.right ==null && q.Count==0)
                    {
                        break;
                    }
                    result.Add(null);
                }
                else
                {
                    result.Add(t.left.val);
                    if (t.left.left!=null|| t.left.right !=null)
                    {
                        q.Enqueue(t.left);
                    }
                   
                }

                
                if (t.right == null)
                {
                    result.Add(null);
                }
                else
                {
                    result.Add(t.right.val);
                    if (t.right.left != null || t.right.right != null)
                    {
                        q.Enqueue(t.right);
                    }
                }
            }



            //Console.WriteLine(tn.val);
          // var ress = new int?[]{2,3,null};
            var res = result.ToArray();
            return res;

        }

        public TreeNode ConvertLevelOrderArrayToATreeNode(int?[] levelOrderArray)
        {
            var sortedArr = levelOrderArray.Where(c => c != null).OrderBy(i => i).ToArray();

            var notNullSortArr = new int[sortedArr.Length];

            for (var i = 0; i < sortedArr.Length; i++)
            {
                if (sortedArr[i]!=null)
                {
                    notNullSortArr[i] = sortedArr[i].Value;
                }
            }
            return SortedArrayToBST(notNullSortArr);
        }

        public int[] ConvertBSTToSortedArray(TreeNode tn)
        {
           
            var sortedArr = ConvertBSTToLevelOrderArray(tn).Where(c => c != null).OrderBy(i => i).ToArray();

            var notNullSortArr = new int[sortedArr.Length];

            for (var i = 0; i < sortedArr.Length; i++)
            {
                if (sortedArr[i] != null)
                {
                    notNullSortArr[i] = sortedArr[i].Value;
                }
            }

            return notNullSortArr;
        }

        /// <summary>
        /// Normal Binary Tree
        /// </summary>
        /// <param name="levelOrderArray"></param>
        /// <returns></returns>
        public TreeNode GetABinaryTreeWithLevelOrderArray(int?[] levelOrderArray)
        {
            if (levelOrderArray[0]==null)
            {
                return null;
            }
            Queue<TreeNode> treeQueue = new Queue<TreeNode>();

            var valueQueue = new Queue<int?>();

            foreach (var t in levelOrderArray)
            {
                valueQueue.Enqueue(t);
            }

            var root = new TreeNode(valueQueue.Dequeue().Value);
            var pointer = root;


            while (valueQueue.Count !=0)
            {
                var value = valueQueue.Dequeue();
                if (value!=null)
                {
                    pointer.left = new TreeNode(value.Value);
                    treeQueue.Enqueue(pointer.left);
                }

                if (valueQueue.Count !=0)
                {
                    value = valueQueue.Dequeue();
                    if (value !=null)
                    {
                        pointer.right = new TreeNode(value.Value);
                        treeQueue.Enqueue(pointer.right);
                    }
                    

                }
                  pointer = treeQueue.Dequeue();
            }
            
            return root;
        }

    }
}
