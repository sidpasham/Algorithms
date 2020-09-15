using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class HeightofBST
    {
        //static void Main()
        //{

        //}

        public static int GetHeight(BSTNode root)
        {
            if (root == null) return 0;

            int left = GetHeight(root.left);
            int right = GetHeight(root.right);

            if (left > right)
            {
                return left + 1;
            }
            else
            {
                return right + 1;
            }
        }
    }
}
