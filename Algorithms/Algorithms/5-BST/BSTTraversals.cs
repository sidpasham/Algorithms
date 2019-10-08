using System;
using System.Collections.Generic;

namespace Algorithms
{
    class BSTTraversals
    {
        //static void Main()
        //{
        //    BST bst = new BST();

        //    bst.Insert(5);
        //    bst.Insert(1);
        //    bst.Insert(2);
        //    bst.Insert(3);
        //    bst.Insert(4);

        //    InOrderRecursion(bst.root);
        //    Console.WriteLine();
        //    InOrderIterative(bst.root);
        //    Console.WriteLine();

        //    PreOrderRecursive(bst.root);
        //    Console.WriteLine();
        //    PreOrderIterative(bst.root);
        //    Console.WriteLine();

        //    PostOrderRecursive(bst.root);
        //    Console.WriteLine();
        //    PostOrderIterative(bst.root);
        //    Console.WriteLine();
        //}

        static void InOrderRecursion(BSTNode root)
        {
            if (root == null) return;

            InOrderRecursion(root.left);

            Console.Write(root.val + " ");

            InOrderRecursion(root.right);
        }

        static void InOrderIterative(BSTNode root)
        {
            if (root == null) return;

            Stack<BSTNode> st = new Stack<BSTNode>();

            var curr = root;

            while (curr != null || st.Count > 0)
            {
                while (curr != null)
                {
                    st.Push(curr);
                    curr = curr.left;
                }

                curr = st.Pop();
                Console.Write(curr.val + " ");

                curr = curr.right;
            }

        }

        static void PreOrderRecursive(BSTNode root)
        {
            if (root == null) return;

            Console.Write(root.val + " ");
            PreOrderRecursive(root.left);
            PreOrderRecursive(root.right);
        }

        static void PreOrderIterative(BSTNode root)
        {
            if (root == null) return;

            Stack<BSTNode> st = new Stack<BSTNode>();

            st.Push(root);

            while (st.Count > 0)
            {
                var node = st.Peek();
                Console.Write(node.val + " ");
                st.Pop();

                if (node.right != null)
                {
                    st.Push(node.right);
                }

                if (node.left != null)
                {
                    st.Push(node.left);
                }
            }
        }

        static void PostOrderRecursive(BSTNode root)
        {
            if (root == null) return;

            PostOrderRecursive(root.left);
            PostOrderRecursive(root.right);
            Console.Write(root.val + " ");
        }

        static void PostOrderIterative(BSTNode root)
        {
            if (root == null) return;

            Stack<BSTNode> st1 = new Stack<BSTNode>();
            Stack<BSTNode> st2 = new Stack<BSTNode>();

            st1.Push(root);
            while (st1.Count > 0)
            {
                var temp = st1.Pop();

                st2.Push(temp);
                if (temp.right != null)
                {
                    st1.Push(temp.right);
                }

                if (temp.left != null)
                {
                    st1.Push(temp.left);
                }
            }

            while (st2.Count > 0)
            {
                var node = st2.Pop();
                Console.Write(node.val + " ");
            }
        }
    }
}
