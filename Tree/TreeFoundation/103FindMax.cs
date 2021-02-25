using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public int FindMax(TreeNode root)
        {
            if (root == null)
                return 0;
            var curr = root;
            while (curr.right != null)
            {
                curr = curr.right;
            }

            return curr.val;
        }
    }
}
