using System;
using System.Collections.Generic;
using System.Text;

namespace StackDemo
{
    /// <summary>
    /// implements a buffer queue
    /// </summary>
    class Queue
    {
        private string[] q;
        /// <summary>
        /// front pointer
        /// </summary>
        private int f;
        /// <summary>
        /// rear pointer
        /// always points to free space
        /// </summary>
        private int r;

        public Queue(int maxsize)
        {
            q = new string[maxsize];
            Reset();
        }
        private void Reset()
        {
            f = 0;
            r = 0;
        }
        public void EnQueue(string item)
        {
            if (r == q.Length)
            {
                Console.WriteLine("Queue full - wahhhhhahhh");
            }
            else
            {
                q[r] = item;
                r = r + 1;
            }

        }
        /// <summary>
        /// attempts to return front of queue
        /// </summary>
        /// <returns>the date item or null if empty</returns>
        public string DeQueue()
        {
            if (f == r)
            {
                Console.WriteLine("Q Empty ':->");
            }
            else 
            {
                string item = q[f];
                f = f + 1;
                // reset buffer if exhausted/emptied
                if (f == q.Length)
                    Reset();
                return item;
            }
            return null;
        }

    }
}
