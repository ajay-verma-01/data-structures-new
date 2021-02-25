using System;
using System.Collections.Generic;
using System.Text;

namespace TreeFoundation
{
    public partial class BinarySearchTree
    {
        public TreeNode Root { get; set; }
        public BinarySearchTree()
        { 
            
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
    }
}
