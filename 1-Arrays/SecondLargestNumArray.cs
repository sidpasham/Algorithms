namespace Algorithms.Arrays
{
    class SecondLargestNumArray
    {
        //static void Main()
        //{
        //    int[] arr1 = { 1, 2, 3, 4, 5,6 };
        //    var output = SecondLargestinArray(arr1);
        //    Console.WriteLine(output);
        //}

        //O(n)
        static int SecondLargestinArray(int[] arr)
        {
            if (arr.Length < 2) return -1;

            int first = int.MinValue;
            int second = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                //if element is greater than first the assign first to second and first to element
                if (arr[i] > first)
                {
                    second = first;
                    first = arr[i];
                }

                //check if element is between first and second
                if (arr[i] > second && arr[i] != first)
                {
                    second = arr[i];
                }
            }
            return second;
        }
    }
}
