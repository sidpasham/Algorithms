using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Amazon
{
    class prioritzeOrders
    {
        //static void Main()
        //{

        //}

        //O(nLogn) Time complexity
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
        }

        private static Dictionary<string, string> SortBoxesByValueKey(Dictionary<string, string> Orders)
        {
            return Orders.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }
        
    }
}
