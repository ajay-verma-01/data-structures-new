using System;
using System.Collections.Generic;
using System.Text;

namespace TreeLive
{
    public partial class BinarySearchTree
    {

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);


            while (q.Count > 0)
            {
                var levelList = new List<int>();
                var count = q.Count;        //Keep the count of the level to print
                for (int i = 0; i < count; i++)
                {
                    var node = q.Dequeue();
                    levelList.Add(node.val);

                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                }

                result.Add(levelList);
            }

            return result;
        }
    }
}
