using System;
using System.Collections.Generic;
using System.Text;

namespace StackDemo
{
    class Searching
    {
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
