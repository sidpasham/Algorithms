using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BST
{
    public class BSTNode
    {
        public int? val;
        public BSTNode left = null;
        public BSTNode right = null;
        public BSTNode(int? data)
        {
            val = data;
            left = null;
            right = null;
        }
    }
}
