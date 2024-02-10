using Algorithms;

namespace Algorithms
{
    class GetMinValuefromBST
    {
        //static void Main()
        //{

        //}

        static int MinValueFromBST(BSTNode root)
        {
            if (root == null) return -1;

            var temp = root;

            while (temp.left != null)
            {
                temp = temp.left;
            }

            if (temp.left?.val != null) return (int) temp.left.val;

            return -1;
        }
    }
}
