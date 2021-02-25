using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public TreeNode Insert(TreeNode root, int val)
        {

            var newNode = new TreeNode(val);
            if (root == null)
            {
                root = newNode;
                return root;
            }

            TreeNode prev = null;
            var curr = root;
            while (curr != null)
            {
                if (curr.val == val)
                {
                    Console.WriteLine("Same value alreday exist");
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

            if (val < prev.val)
            {
                prev.left = newNode;
            }
            else
            {
                prev.right = newNode;
            }

            return root;
        }
    }
}
