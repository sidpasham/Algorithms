using System.Collections.Generic;

namespace Algorithms
{
    public class IsSymmetric
    {
        //static void Main()
        //{

        //}

        //O(n) time complexity
        //O(1) space
        public static bool IsIdenticalIterative(BSTNode root1, BSTNode root2)
        {
            Queue<BSTNode> q = new Queue<BSTNode>();

            q.Enqueue(root1);
            q.Enqueue(root2);

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

        //O(n) time complexity
        //O(n) space
        public static bool IsIdenticalRecursive(BSTNode t1, BSTNode t2)
        {
            if (t1 == null && t2 == null) return true;

            if (t1 == null || t2 == null) return false;

            return (t1.val == t2.val && IsIdenticalRecursive(t1.left, t2.left) &&
                    IsIdenticalRecursive(t1.right, t2.right));
        }
    }
}
