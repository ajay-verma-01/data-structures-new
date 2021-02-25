using System;

namespace LinkedListFoundation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList ll = new LinkedList();
            ll.Append(10);
            ll.Append( 20);
            ll.Append( 30);
            ll.Append( 40);
            ll.Append( 50);
            ll.Append( 60);
            ll.Append( 70);

            ll.Print();

            Console.WriteLine("\nAdd 11 at index 2");
            ll.InsertAt(11, 2);

            ll.Print();

            Console.WriteLine("\nRemove 11 at index 2");
            ll.RemoveAt(2);
            ll.Print();

            Console.WriteLine("\nGet at index 2");
            Console.WriteLine(ll.GetAt(2));

            Console.ReadKey();


        }
    }
}
