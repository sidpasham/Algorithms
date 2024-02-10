namespace Algorithms.Arrays
{
    class PushZerostoEnd
    {
        //static void Main()
        //{
        //    int[] arr = new int[] {1,0,0,5,6,0,3,8,9};

        //    PushAllZerostoEnd(arr);

        //    Console.WriteLine();
        //}

        //O(n) time complexity
        //O(1) space
        static void PushAllZerostoEnd(int[] arr)
        {
            if(arr.Length == 0) return;
            int count = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count] = arr[i];
                    count++;
                }
            }

            while (count < n)
            {
                arr[count] = 0;
                count++;
            }
        }
    }
}
