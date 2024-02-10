using System;
using System.Collections.Generic;

namespace Algorithms
{
    class LevelOrderTraversal
    {
        //static void Main()
        //{
        //    BST bst = new BST();
        //    bst.Insert(3);
        //    bst.Insert(9);
        //    bst.Insert(20);
        //    bst.Insert(null);
        //    bst.Insert(null);
        //    bst.Insert(15);
        //    bst.Insert(7);

        //    var output = GetLevelOrder(bst.root);

        //}

        public static List<List<int>> GetLevelOrder(BSTNode root)
        {
            List<List<int>> lst = new List<List<int>>();
            if (root == null) return lst;

            var h = HeightofBST.GetHeight(root);

            for (int i = 1; i <= h; i++)
            {
                lst.Add(GetLevelOrderRecursive(root, i));
            }

            return lst;
        }

        public static List<int> GetLevelOrderRecursive(BSTNode root, int level)
        {
            List<int> l = new List<int>();

            if (root == null) return l;

            if(level == 1)
                if (root.val != null)
                    l.Add((int) root.val);

            if (level > 1)
            {
                GetLevelOrderRecursive(root.left, level - 1);
                GetLevelOrderRecursive(root.right, level - 1);
            }

            return l;
        }

        public static IList<IList<int>> GetLevelOrderIterative(BSTNode root)
        {
            IList<IList<int>> lst = new List<IList<int>>();

            if (root == null) return lst;

            Queue<BSTNode> q = new Queue<BSTNode>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                IList<int> l = new List<int>();

                var height = q.Count;

                for (int i = 1; i <= height; i++)
                {
                    var temp = q.Dequeue();

                    if (temp.val != null) l.Add((int) temp.val);

                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }

                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                }

                lst.Add(l);
            }

            return lst;

        }



        void PrintGivenLevel(BSTNode root, int level)
        {
            if (root == null) return;
            if (level == 1) Console.Write(root.val + " ");

            if (level > 1)
            {
                PrintGivenLevel(root.left, level - 1);
                PrintGivenLevel(root.right, level - 1);
            }

        }

        public void PrintLevelOrderRecursive(BSTNode root)
        {
            var height = HeightofBST.GetHeight(root);

            for (int i = 0; i <= height; i++)
            {
                PrintGivenLevel(root, i);
            }
        }

        public void PrintLevelOrderIterative(BSTNode root)
        {
            if (root == null) return;

            Queue<BSTNode> q = new Queue<BSTNode>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                var temp = q.Dequeue();
                Console.Write(temp.val + " ");

                if (temp.left != null)
                {
                    q.Enqueue(temp.left);
                }

                if (temp.right != null)
                {
                    q.Enqueue(temp.right);
                }
            }
        }

    }
}
