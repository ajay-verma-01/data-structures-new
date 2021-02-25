using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public void PrintBookContent(TreeNode root)
        {
            Helper(root, 0);
        }

        private void Helper(TreeNode node, int level)
        {
            if (node == null)
                return;

            Console.WriteLine(String.Format("%1$" + level + "s", "") + node.val);

            foreach (var child in node.Children)
            {
                Helper(child, level + 1);   
            }
        }
    }
}
