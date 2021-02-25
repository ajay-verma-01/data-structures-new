using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public double Helper(TreeNode node)
        {
            if (node == null)
                return 0;

            double du = node.val;

            foreach (var child in node.Children)
            {
                du = du + Helper(child);
            }

            return du;
        }
    }
}
