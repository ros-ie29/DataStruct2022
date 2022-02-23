using System;
using System.Collections.Generic;
using System.Text;

namespace StackDemo
{
    class Searching
    {
        public static int Binary(int[] list, int item)
        {
            int l = 0;
            int r = list.Length - 1;

            while (l <= r)
            {
                int m = (l + r) / 2;
                if (item == list[m]) 
                    return m;
                else if (item < list[m])
                    r = m - 1;
                else // if (item > list[m])
                    l = m + 1;
            }
            return -1;
        }
        /// <summary>
        /// Performs a search of given array
        /// </summary>
        /// <param name="list">data set to investigate</param>
        /// <param name="item">search value</param>
        /// <returns>index item found or -1 if item not found</returns>
        public static int Linear(int[] list, int item)
        {
            int p = 0;
            while (p < list.Length)
            {
                if (list[p] == item)
                    return p;
                else
                    p++;
            }
            return -1;
        }
    }
}
