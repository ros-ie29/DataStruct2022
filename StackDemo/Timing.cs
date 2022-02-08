using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace StackDemo
{
    class Timing
    {
        public static void ShowStopWatch(Stopwatch watch)
        {
            TimeSpan ts = watch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime + " ticks:" + watch.ElapsedTicks);
        }
    }
}
