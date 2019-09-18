using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Amazon
{
    class Interview1
    {
        static void Main()
        {

        }

        public static List<string> prioritizedOrders(int numOrders, string[] orderList)
        {
            if (numOrders == 0) return null;
            Dictionary<string, string> oldGenBoxes = new Dictionary<string, string>();
            Dictionary<string, string> newGenBoxes = new Dictionary<string, string>();

            foreach (string order in orderList)
            {
                string[] splitedOrder = order.Split(' ');
                if (!Int32.TryParse(splitedOrder[1], out int n))
                {
                    oldGenBoxes.Add(order, order.Substring(order.IndexOf(' ')));
                }
                else
                {
                    newGenBoxes.Add(order, order.Substring(order.IndexOf(' ')));
                }
            }

            Dictionary<string, string> sortedOldGenBoxes = SortBoxesByValueKey(oldGenBoxes);

            newGenBoxes.ToList().ForEach(x => sortedOldGenBoxes.Add(x.Key, x.Value));
            return sortedOldGenBoxes.Keys.ToList();

            // WRITE YOUR CODE HERE
        }

        private static Dictionary<string, string> SortBoxesByValueKey(Dictionary<string, string> Orders)
        {
            return Orders.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

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
                    int backwad = b[1];
                    int total = (forward + backwad);
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
