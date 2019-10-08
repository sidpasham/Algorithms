namespace Algorithms
{
    class ArraytoBST
    {
        //static void Main()
        //{
        //    BST bst = new BST();
        //    int[] arr = new int[]{1,8,6,9,2,3,7,5};
        //    InsertArraytoBST(arr, bst);

        //    bst.InOrderRecursion();

        //}

        //O(n) time complexity
        //O(1) space
        static void InsertArraytoBST(int[] arr, BST bst)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bst.Insert(arr[i]);
            }
        }


        //O(n) time complexity
        //O(n) space
        static BSTNode SortedArraytoBST(int[] arr, int start, int end)
        {
            if(start > end) return null;

            int mid = (start + end) / 2;
            BSTNode node = new BSTNode(arr[mid]);

            node.left = SortedArraytoBST(arr, start, mid - 1);
            node.right = SortedArraytoBST(arr, mid + 1, end);

            return node;
        }
    }
}
