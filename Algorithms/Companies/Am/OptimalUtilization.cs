using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Amazon
{
    class OptimalUtilization
    {
        //static void Main()
        //{

        //}

        //O(n^2) Time complexity
        public static List<List<int>> optimalUtilization(int maxTravelDist, List<List<int>> forwardRouteList, List<List<int>> returnRouteList)
        {
            if (forwardRouteList.Count == 0 && returnRouteList.Count == 0) return new List<List<int>>();

            List<List<int>> result = new List<List<int>>();
            List<List<int>> max = new List<List<int>>();
            var forwardList = forwardRouteList.Where(x => x[1] < maxTravelDist).OrderByDescending(list => list[1]);
            var backwardList = returnRouteList.Where(x => x[1] < maxTravelDist).OrderByDescending(list => list[1]);
            int prev = 0;

            foreach (List<int> f in forwardList)
            {
                foreach (List<int> b in backwardList)
                {
                    int forward = f[1];
                    int backward = b[1];
                    int total = (forward + backward);
                    if (total > maxTravelDist)
                        continue;
                    if (total < maxTravelDist)
                    {
                        if (max.Count == 0)
                        {
                            max.Add(new List<int>(new int[] { f[0], b[0] }));
                            prev = total;
                        }
                        else if (max.Count > 0 && total == prev)
                        {
                            max.Add(new List<int>(new int[] { f[0], b[0] }));
                        }
                    }
                    else if (total == maxTravelDist)
                    {
                        result.Add(new List<int>(new int[] { f[0], b[0] }));
                        break;
                    }
                }
            }
            if (result.Count > 0)
                return result;
            else if (max.Count > 0)
            {
                return max;
            }
            else
                return new List<List<int>>();

        }
    }
}
