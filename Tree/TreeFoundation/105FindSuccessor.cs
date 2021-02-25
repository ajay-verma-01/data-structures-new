using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public TreeNode FindSuccessor(TreeNode root, TreeNode p)
        {
            if (root == null)
                return null;

            TreeNode curr = null;
            if (p.right != null)
            {
                curr = p.right;
                while (curr.left != null)
                {
                    curr = curr.left;
                }
                return curr;
            }

            TreeNode ancestor = null;
            curr = root;
            while (curr.val != p.val)
            {
                if (p.val < curr.val)
                {
                    ancestor = curr;
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            return ancestor;
        }
    }
}
