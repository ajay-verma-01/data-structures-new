using System;

namespace TreeFoundation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinarySearchTree bt = new BinarySearchTree();
            var root = bt.Insert(null, 44);
            root = bt.Insert(root, 17);
            root = bt.Insert(root, 88);
            root = bt.Insert(root, 8);
            root = bt.Insert(root, 32);
            root = bt.Insert(root, 65);
            root = bt.Insert(root, 97);
            root = bt.Insert(root, 28);
            root = bt.Insert(root, 54);
            root = bt.Insert(root, 82);
            root = bt.Insert(root, 93);
            root = bt.Insert(root, 29);
            root = bt.Insert(root, 76);
            root = bt.Insert(root, 80);

            Console.WriteLine("Print Tree First Time");
            bt.PrintInOrderRec(root);

            Console.WriteLine("\nPrint Search Node 80");
            var searchRoot = bt.Search(root, 80);
            bt.PrintInOrderRec(searchRoot);

            Console.WriteLine("\nFindMin");
            var min = bt.FindMin(root);
            Console.WriteLine(min);

            Console.WriteLine("\nFindMax");
            var max = bt.FindMax(root);

            Console.WriteLine(max);

            Console.WriteLine("\nFindSuccessor");
            var successor = bt.FindSuccessor(root, root);
            Console.WriteLine(successor.val);

            Console.WriteLine("\nFindPredecessor");
            var predecessor = bt.FindPredecessor(root, root);
            Console.WriteLine(predecessor.val);

            Console.WriteLine("\nDelete 88");
            //var delete1 = bt.Delete(root, 88);
            //bt.PrintInOrderRec(delete1);

            Console.WriteLine("\nDelete 32");
            //var delete2 = bt.Delete(root, 32);
            //bt.PrintInOrderRec(delete2);


            Console.WriteLine("\nLevel Order");
            bt.LevelOrder(root);
            Console.WriteLine("\n");


            Console.ReadKey();
        }
    }
}
