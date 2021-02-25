using System;

namespace TreeLive
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BinarySearchTree bt = new BinarySearchTree();
            var root = bt.Insert(null, 44);
            root = bt.Insert(root, 17);
            var root1 = bt.Insert(root, 88);
            root = bt.Insert(root1, 8);
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


            var levelOrder = bt.LevelOrder(root);
            Console.WriteLine("\n------Level Order-------");
            foreach (var list in levelOrder)
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        
       

            Console.ReadKey();
        }
    }
}
