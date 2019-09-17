namespace Algorithms.BST
{
    public class IsIdentical
    {
        //static void Main()
        //{

        //}

        public static bool IsTreesIdenticalRecursive(BSTNode t1, BSTNode t2)
        {
            if (t1 == null && t2 == null) return true;

            if (t1 == null || t2 == null) return false;

            return (t1.val == t2.val && IsTreesIdenticalRecursive(t1.left, t2.left) &&
                    IsTreesIdenticalRecursive(t1.right, t2.right));
        }
    }
}
