namespace Algorithms.Arrays
{
    class CountSubArrayProductLessThanK
    {
        static int CountSubArrayProductLessThanKBruteForce(int[] arr, int k)
        {
            if(k == 0)
            {
                return 0;
            }

            int p;
            int count = 0;
            int n = arr.Length;
            for(int i =0; i< n; i++)
            {
                p = arr[i];

                if(p < k)
                {
                    count++;
                }

                for(int j = i+1; j<n; j++)
                {
                    p = p * arr[j];

                    if(p < k)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return count;
        }

        static int CountSubArrayProductLessThanKSlidingWindow(int[] arr, int k)
        {
            if(k == 0)
            {
                return 0;
            }
            int p = 1;
            int count = 0;

            for(int start = 0, end = 0; end < arr.Length; end++)
            {
                p = p * arr[end];

                while(start < end  && p>=k)
                {
                    start++;
                    p = p/arr[start];
                }

                if(p<k)
                {
                    int len = (end-start) + 1;
                    count = count + len;
                }
            }

            return count;
        }
    }
}
