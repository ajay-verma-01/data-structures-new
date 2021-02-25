using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public TreeNode Search(TreeNode root, int val)
        {
            if (root == null)
                return null;

            var curr = root;

            while (curr != null)
            {
                if (curr.val == val)
                {
                    return curr;
                }
                else if (val < curr.val)
                {
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            return null;
        }

    }
}
