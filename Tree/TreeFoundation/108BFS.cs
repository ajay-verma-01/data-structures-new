using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public void LevelOrder(TreeNode root)
        {
            var q = new Queue<TreeNode>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                var node = q.Dequeue();
                Console.Write(node.val + "  ");

                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }
            }
        }
    }
}
