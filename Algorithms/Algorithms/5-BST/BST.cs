using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class BST
    {
        public BSTNode root;

        public BST()
        {
            root = null;
        }

        public void Insert(int? data)
        {
            root = Insert(root, data);
        }

        BSTNode Insert(BSTNode root, int? data)
        {
            if (root == null)
            {
                root = new BSTNode(data);
                return root;
            }

            if(data < root.val)
            {
                root.left = Insert(root.left, data);
            }
            else
            {
                root.right = Insert(root.right, data);
            }
            return root;
        }

        #region Traversals

        public void InOrderRecursion()
        {
            InOrderRecursion(root);
        }

        void InOrderRecursion(BSTNode root)
        {
            if (root == null) return;

            InOrderRecursion(root.left);

            Console.Write(root.val + " ");

            InOrderRecursion(root.right);
        }

        public void InOrderIterative()
        {            
            if (root == null) return;

            Stack<BSTNode> st = new Stack<BSTNode>();

            var curr = root;

            while(curr != null || st.Count > 0)
            {
                while(curr != null)
                {
                    st.Push(curr);
                    curr = curr.left;
                }

                curr = st.Pop();
                Console.Write(curr.val + " ");

                curr = curr.right;
            }

        }

        public void PreOrderRecursive()
        {
            PreOrderRecursive(root);
        }

        void PreOrderRecursive(BSTNode root)
        {
            if (root == null) return;

            Console.Write(root.val + " ");
            PreOrderRecursive(root.left);
            PreOrderRecursive(root.right);
        }

        public void PreOrderIterative()
        {
            if (root == null) return;

            Stack<BSTNode> st = new Stack<BSTNode>();

            st.Push(root);

            while(st.Count > 0)
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

        public void PostOrderRecursive()
        {
            PostOrderRecursive(root);
        }

        void PostOrderRecursive(BSTNode root)
        {
            if (root == null) return;

            PostOrderRecursive(root.left);
            PostOrderRecursive(root.right);
            Console.Write(root.val + " ");
        }

        public void PostOrderIterative()
        {
            if (root == null) return;

            Stack<BSTNode> st1 = new Stack<BSTNode>();
            Stack<BSTNode> st2 = new Stack<BSTNode>();

            st1.Push(root);
            while(st1.Count > 0)
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

            while(st2.Count > 0)
            {
                var node = st2.Pop();
                Console.Write(node.val + " ");
            }
        }

        #endregion
    }
}
