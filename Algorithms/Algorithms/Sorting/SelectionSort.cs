namespace Algorithms.Sorting
{
    class SelectionSort
    {
        //static void Main()
        //{
        //    int[] arr = { 64, 25, 12, 22, 11 };
        //    SelectionSorting(arr);
        //    Console.WriteLine(string.Join("\t",arr));
        //}

        static void SelectionSorting(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int mi = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[mi]) mi = j;
                }

                var temp = arr[mi];
                arr[mi] = arr[i];
                arr[i] = temp;

            }
        }
    }
}
