using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public TreeNode Delete(TreeNode root, int val)
        {
            //first search the element
            var curr = root;
            TreeNode prev = null;
            while (curr != null)
            {
                if (val == curr.val)
                {
                    break;
                }

                else if (val < curr.val)
                {
                    prev = curr;
                    curr = curr.left;
                }
                else
                {
                    prev = curr;
                    curr = curr.right;
                }
            }

            if (curr == null)
                return root;

            //Case1 current node is leaf
            if (curr.left == null && curr.right == null)
            {

                if (prev == null) //One node tree//edge case
                {
                    return null;
                }

                if (prev.left.val == curr.val)
                {
                    prev.left = null;
                }
                else
                {
                    prev.right = null;
                }
            }

            //Case2 If current node has one child
            TreeNode child = null;

            if (curr.left == null && curr.right != null)
            {
                child = curr.right;
            }
            if (curr.left != null && curr.right == null)
            {
                child = curr.left;
            }

            if (child != null)
            {
                if (prev == null) //Edge case if node is immdiate child of root
                {
                    root = child;
                    return root;
                }

                if (curr == prev.left)
                {
                    prev.left = child;
                }
                else
                {
                    prev.right = child;
                }

                return root;
            }

            //Case 3 current node has two children
            if (curr.left != null && curr.right != null)
            {
                var succ = curr.right;
                prev = curr;

                while (succ.left != null)
                {
                    prev = succ;
                    succ = succ.left;
                }

                curr.val = succ.val;

                if(succ == prev.left)
                {
                    prev.left = succ.right; // there will be no left node of successor

                }
                else
                {
                    prev.right = succ.right; //there will be no left node of successor
                }

                
            }

            return root;
        }
    }
}
