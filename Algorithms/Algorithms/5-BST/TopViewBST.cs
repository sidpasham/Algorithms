using System;
using System.Collections.Generic;

namespace Algorithms
{
    class BSTPair
    {
        public BSTNode first;
        public int second;

        public BSTPair(BSTNode node, int data)
        {
            first = node;
            second = data;
        }
    }
    class TopViewBST
    {
        //static void Main()
        //{
        //    BST bst = new BST();
        //    bst.Insert(8);
        //    bst.Insert(5);
        //    bst.Insert(1);
        //    bst.Insert(3);
        //    bst.Insert(7);

        //    PrintTopViewBST(bst.root);
        //}

        static void PrintTopViewBST(BSTNode root)
        {
            if(root == null) return;

            Queue<BSTPair> q = new Queue<BSTPair>();

            q.Enqueue(new BSTPair(root, 0));

            Dictionary<int,int> dict = new Dictionary<int, int>();

            //BFS
            while (q.Count > 0)
            {
                var temp = q.Peek().first;
                var d = q.Peek().second;
                q.Dequeue();

                if (!dict.ContainsKey(d))
                {
                    Console.Write(temp.val + " ");
                    if (temp.val != null) dict.Add(d, (int) temp.val);
                }

                if (temp.left != null)
                {
                    q.Enqueue(new BSTPair(temp.left,d -1));
                }

                if (temp.right != null)
                {
                    q.Enqueue(new BSTPair(temp.right, d+ 1));
                }
            }

        }
    }
}
