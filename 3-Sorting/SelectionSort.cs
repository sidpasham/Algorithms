namespace Algorithms
{
    class SelectionSort
    {
        //static void Main()
        //{
        //    int[] arr = { 64, 25, 12, 22, 11 };
        //    SelectionSorting(arr);
        //    Console.WriteLine(string.Join("\t",arr));
        //}

        //O(n^2)
        static void SelectionSorting(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int min_idx = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_idx]) min_idx = j;
                }

                var temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;

            }
        }
    }
}
