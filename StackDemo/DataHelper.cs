using System;
using System.Collections.Generic;
using System.Text;

namespace StackDemo
{
    /// <summary>
    /// methods to help generate test data
    /// </summary>
    class DataHelper
    {
        static Random r = new Random();
        static bool[] picked;

        public static int[] RandomOrderedList(int size)
        {
            int[] list = new int[size];
            int num = 0;
            for (int p = 0; p < list.Length; p++)
            {
                num = r.Next(num + 1, num + 10);
                list[p] = num;
            }
            return list;
        }

        /// <summary>
        /// Generates a non repeating list of random values
        /// </summary>
        /// <param name="size">how big do you want it mate</param>
        /// <returns>duh</returns>
        public static int[] RandomList(int size)
        {
            int[] list = new int[size];
            ResetPicks(size * 10);

            for (int p = 0; p < list.Length; p++)
                list[p] = GetNumber();
            return list;
        }
        /// <summary>
        /// show list to console
        /// </summary>
        /// <param name="list">this one</param>
        internal static void Show(int[] list)
        {
            for (int p = 0; p < list.Length; p++)
            {
                Console.Write(list[p] + " ");
            }
        }

        private static int GetNumber()
        {
            int num = r.Next(1, picked.Length);
            while (picked[num])
                num = r.Next(1, picked.Length);

            picked[num] = true;
            return num;
        }

        private static void ResetPicks(int size)
        {
            picked = new bool[size];
            for (int i = 0; i < picked.Length; i++)
                picked[i] = false;
        }
    }
}
