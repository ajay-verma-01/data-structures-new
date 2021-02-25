using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public TreeNode FindPredecessor(TreeNode root, TreeNode p)
        {
            if (root == null)
                return null;

            TreeNode curr = null;
            if (p.left != null)
            {
                curr = p.left;
                while (curr.right != null)
                {
                    curr = curr.right;
                }
                return curr;
            }

            TreeNode ancestor = null;
            curr = root;
            while (curr.val != p.val)
            {
                if (p.val < curr.val)
                {
                    curr = curr.left;
                }
                else
                {
                    ancestor = curr;
                    curr = curr.right;
                }
            }

            return ancestor;
        }
    }
}
