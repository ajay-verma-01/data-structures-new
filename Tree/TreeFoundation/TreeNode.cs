using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public List<TreeNode> Children;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
