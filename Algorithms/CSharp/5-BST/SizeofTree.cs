namespace Algorithms
{
    class SizeofTree
    {
        //static void Main()
        //{

        //}

        static int  GetSizeofTreeRecursion(BSTNode root)
        {
            if(root == null) return 0;

            return GetSizeofTreeRecursion(root.left) + GetSizeofTreeRecursion(root.right) + 1;
        }



    }
}
