using System;
using System.Collections.Generic;
using System.Text;

namespace TreeLive
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

    public class Node
    {
        public int val;
        public List<Node> children;
        public Node(int val = 0, List<Node> children = null)
        {   
            this.val = val;
            this.children = children;
        }
    }
}
