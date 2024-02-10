namespace Algorithms.Arrays
{
    public class SortArrayInWaveForm
    {
        //static void Main()
        //{
        //    int[] arr = new int[] {0,0,1,1,1,0,1,0,1,1,1,0,0 };

        //    var output = SortArrayinBinaryOrder(arr);

        //    Console.WriteLine(string.Join("\t", output));
        //}

        static int[] SortArrayInWaveFormBruteForce(int[] arr)
        {

            //First Sort the Array
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1 ; i +=2 )
            {
                Swap(arr, i, i+1);
            }

            return arr;
        }

        static int[] SortArrayInWaveFormOptimized(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                if(i > 0 && arr[i] < arr[i-1])
                {
                    Swap(arr, i-1, i);
                }

                if(i < arr.Length - 1 && arr[i] < arr[i+1])
                {
                    Swap(arr, i, i+1);
                }
            }

            return arr;
        }

        static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}