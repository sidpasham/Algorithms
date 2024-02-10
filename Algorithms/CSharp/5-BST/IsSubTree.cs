namespace Algorithms
{
    class IsSubTree
    {
        //static void Main()
        //{

        //}

        static bool CheckIfSubTree(BSTNode T, BSTNode S)
        {
            if (S == null) return true;

            if (T == null) return false;

            if (IsSymmetric.IsIdenticalRecursive(T, S)) return true;

            return CheckIfSubTree(T.left, S) || CheckIfSubTree(T.right, S);
        }
    }
}
