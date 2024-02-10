namespace Algorithms
{
    class MergeSort
    {
        //static void Main()
        //{
        //    int[] arr = new int[] { 5, 6, 8, 1, 3, 9, 4, 7 };
        //    Sort(arr, 0, arr.Length-1);
        //    Console.WriteLine(string.Join("\t",arr));
        //}

        //O(nLog(N))
        //space = O(n)
        static void Merge(int[] arr, int start, int end, int middle)
        {
            int n1 = middle - start + 1;
            int n2 = end - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];


            for (int l = 0; l < n1; l++)
            {
                L[l] = arr[start + l];
            }

            for (int m = 0; m < n2; m++)
            {
                R[m] = arr[middle + 1 + m];
            }

            int k = start;
            int i = 0;
            int j = 0;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }

        }

        //O(nLog(N))
        //space = O(n)
        static void Sort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                var middle = (start + end) / 2;

                Sort(arr, start, middle);
                Sort(arr, middle + 1, end);

                Merge(arr, start, end, middle);
            }
        }
    }
}
