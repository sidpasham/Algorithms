using System;

namespace Algorithms
{
    class Height
    {
        public int height = 0;
    }

    class IsTreeBalanced
    {
        //static void Main()
        //{

        //}

        static bool CheckTreeBalancedOptimized(BSTNode root, Height height)
        {
            if (root == null) return true;

            var lheight = new Height();
            var rheight = new Height();
            var lh = lheight.height;
            var rh = rheight.height;

            height.height = (lh > rh ? lh : rh) + 1;

            var l = CheckTreeBalancedOptimized(root.left, lheight);
            var r = CheckTreeBalancedOptimized(root.left, rheight);

            if (Math.Abs(lh - rh) >= 2) return false;
            else return l & r;
        }


        //O(n^2) time complexity
        //O(n) space
        static bool CheckTreeBalancedRecursion(BSTNode root)
        {
            if (root == null) return true;

            var lheight = HeightofBST.GetHeight(root.left);
            var rheight = HeightofBST.GetHeight(root.right);

            return (CheckTreeBalancedRecursion(root.left) && CheckTreeBalancedRecursion(root.right) &&
                    Math.Abs(lheight - rheight) <= 1);
        }
    }
}
