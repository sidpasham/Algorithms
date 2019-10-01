using System.Collections.Generic;

namespace Algorithms.BST
{
    public class IsSymmetric
    {
        //static void Main()
        //{

        //}

        public static bool IsIdenticalRecursive(BSTNode t1, BSTNode t2)
        {
            if (t1 == null && t2 == null) return true;

            if (t1 == null || t2 == null) return false;

            return (t1.val == t2.val && IsIdenticalRecursive(t1.left, t2.left) &&
                    IsIdenticalRecursive(t1.right, t2.right));
        }

        public static bool IsIdenticalIterative(BSTNode root)
        {
            Queue<BSTNode> q = new Queue<BSTNode>();

            q.Enqueue(root);
            q.Enqueue(root);

            while (q.Count > 0)
            {
                BSTNode t1 = q.Dequeue();
                BSTNode t2 = q.Dequeue();

                if (t1 == null && t2 == null) return true;
                if (t1 == null || t2 == null) return false;

                if (t1.val != t2.val) return false;

                q.Enqueue(t1.left);
                q.Enqueue(t2.right);
                q.Enqueue(t1.right);
                q.Enqueue(t2.left);
            }

            return true;

        }
    }
}
