using System;
using System.Collections.Generic;
using System.Text;

namespace StackDemo
{
    class MyInsertionSort
    {
        public static int InsertionSort(int[] list)
        {
            int pos = 0;
            int sortPos = pos + 1;
            int listlen = list.Length;
            while (sortPos < listlen)
            {
                pos++;
                sortPos++;
                if(list[pos] < list[sortPos])
                {
                    int list1 = list[pos];
                    Console.WriteLine(list1);
                }
                else if (list[pos] > list[sortPos])
                {
                    int list2 = list[sortPos];
                    Console.WriteLine(list2);
                }
            }

            return -1;
        }
    }
}
