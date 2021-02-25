using System;
using System.Collections.Generic;
using System.Text;

namespace TreeLive
{
    public partial class BinarySearchTree
    {
        public TreeNode Root { get; set; }
        public BinarySearchTree()
        { 
            
        }

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
            while(curr != null)
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

        //LEFT-ROOT-RIGHT
        public void PrintInOrderRec(TreeNode node)
        {
            if (node == null)
                return;

            PrintInOrderRec(node.left);

            Console.Write(node.val + "   ");

            PrintInOrderRec(node.right);
        }

        //ROOT-LEFT-RIGHT
        public void PrintPreOrderRec(TreeNode node)
        {
            if (node == null)
                return;

            Console.Write(node.val + "   ");
            PrintPreOrderRec(node.left);
            PrintPreOrderRec(node.right);
        }

        //LEFT-RIGHT-ROOT
        public void PrintPostOrderRec(TreeNode node)
        {
            if (node == null)
                return;

            PrintPostOrderRec(node.left);
            PrintPostOrderRec(node.right);
            Console.Write(node.val + "   ");

        }

        public TreeNode Delete(TreeNode root, int val)
        {
            //first search the element
            var curr = root;
            TreeNode prev = null;
            while (curr != null)
            {
                if (val == curr.val)
                {
                    break;
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

            if (curr == null)
                return root;

            //Case1 current node is leaf
            if (curr.left == null && curr.right == null)
            {

                if (prev == null) //One node tree//edge case
                {
                    return null;
                }

                if (prev.left.val == curr.val)
                {
                    prev.left = null;
                }
                else
                {
                    prev.right = null;
                }
            }

            //Case2 If current node has one child
            TreeNode child = null;

            if (curr.left == null && curr.right != null)
            {
                child = curr.right;
            }
            if (curr.left != null && curr.right == null)
            {
                child = curr.left;
            }

            if (child != null)
            {
                if (prev == null) //Edge case if node is immdiate child of root
                {
                    root = child;
                    return root;
                }

                if (curr == prev.left)
                {
                    prev.left = child;
                }
                else
                {
                    prev.right = child;
                }

                return root;
            }

            //Case 3 current node has two children
            if (curr.left != null && curr.right != null)
            {
                var succ = curr.right;
                prev = curr;

                while (succ.left != null)
                {
                    prev = succ;
                    succ = succ.left;
                }

                curr.val = succ.val;

                if (succ == prev.left)
                {
                    prev.left = succ.right; // there will be no left node of successor

                }
                else
                {
                    prev.right = succ.right; //there will be no left node of successor
                }


            }

            return root;
        }

        public TreeNode FindSuccessor(TreeNode root, TreeNode p)
        {
            if (root == null)
                return null;

            TreeNode curr = null;
            if (p.right != null)
            {
                curr = p.right;
                while (curr.left != null)
                {
                    curr = curr.left;
                }
                return curr;
            }

            TreeNode ancestor = null;
            curr = root;
            while (curr.val != p.val)
            {
                if (p.val < curr.val)
                {
                    ancestor = curr;
                    curr = curr.left;
                }
                else
                {
                    curr = curr.right;
                }
            }

            return ancestor;
        }
    }
}
