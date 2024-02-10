using System;

namespace Algorithms.Arrays
{
    class MinSubArayLengthWithKDistintElements
    {
        public int MininumSubArrayLengthBruteForce(int[] arr, int k)
        {
            int n = arr.Length;

            int l = 0, r = n;

            for(int i = 0; i < n; i++)
            {
                HashSet<int> map = new HashSet<int>();

                for(int j =i ; j<n ;j++)
                {
                    map.Add(arr[j]);

                    if(map.Count() == k)
                    {
                        if((j-i) < (r-l))
                        {
                            r = j;
                            l = i;
                        }
                        break;
                    }
                }

                if(i == n) break;
            }

            if(l == 0 && r == n)
            {
                return -1;
            }
            else
            {
                return (r - l) + 1;
            }
        }

        //Sliding window
        public int MininumSubArrayLengthOptimized(int[] arr, int n, int k)
        {
            if(arr == null)
            {
                return -1;
            }

            int l = 0;
            int r = n;
            int j = -1;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i =0; i<n; i++)
            {
                while(j < n)
                {
                    j++;

                    if(map.Count() < k)
                    {
                        if(map.ContainsKey(arr[j]))
                        {
                            map[arr[j]]++;
                        }
                        else
                        {
                            map.Add(arr[j], 1);
                        }
                    }

                    if(map.Count() == k && (r-l) >= (j-i))
                    {
                        r = j;
                        l = i;
                        break;
                    }
                }

                if(map.Count() < k)
                {
                    break;
                }

                while(map.Count() == k)
                {
                    if(map.ContainsKey(arr[i]) && map[arr[i]] == 1)
                    {
                        map.Remove(arr[i]);
                    }
                    else
                    {
                        map[arr[i]] = map[arr[i]] - 1;
                    }

                    i++;

                    if(map.Count() == k && (r-l) >= (j-i))
                    {
                        r = j;
                        l = i;
                    }
                }


                if(map.ContainsKey(arr[i]) && map[arr[i]] == 1)
                {
                    map.Remove(arr[i]);
                }
                else
                {
                    map[arr[i]] = map[arr[i]] - 1;
                }
            }

            if(l == 0 && r == n)
            {
                return -1;
            }
            else
            {
                return (r -l) + 1;
            }
        }
    }
}
