using System;

namespace Algorithms
{
    class BSTTraversals
    {
        //static void Main()
        //{
        //    TraverseBST();
        //}

        static void TraverseBST()
        {
            BST bst = new BST();

            bst.Insert(5);
            bst.Insert(1);
            bst.Insert(2);
            bst.Insert(3);
            bst.Insert(4);

            bst.InOrderRecursion();
            Console.WriteLine();
            bst.InOrderIterative();
            Console.WriteLine();

            bst.PreOrderRecursive();
            Console.WriteLine();
            bst.PreOrderIterative();
            Console.WriteLine();

            bst.PostOrderRecursive();
            Console.WriteLine();
            bst.PostOrderIterative();
            Console.WriteLine();
        }
    }
}
