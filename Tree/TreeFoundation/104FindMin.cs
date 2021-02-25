using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public int FindMin(TreeNode root)
        {
            if (root == null)
                return 0;
            var curr = root;
            while (curr.left != null)
            {
                curr = curr.left;
            }

            return curr.val;
        }
    }
}
