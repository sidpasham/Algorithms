namespace Algorithms
{
    class FindElementInMatrix
    {
        //static void Main()
        //{
        //    int[,] mat = { { 10, 20, 30, 40 },
        //        { 15, 25, 35, 45 },
        //        { 27, 29, 37, 48 },
        //        { 32, 33, 39, 50 } };

        //    var output = FindElement(mat, 29);
        //    Console.WriteLine();
        //}

        static int[] FindElement(int[,] mat, int x)
        {
            var l = 4;

            var i = 0;
            var j = l - 1;

            while (i < l && j >= 0)
            {
                if (mat[i, j] == x) return new int[] {i, j};
                if (mat[i, j] > x) j--;
                if (mat[i, j] < x) i++;
            }

            return null;
        }
    }
}
