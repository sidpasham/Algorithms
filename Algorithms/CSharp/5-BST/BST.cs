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
    }
}
