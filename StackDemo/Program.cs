using System;
using System.Diagnostics;

namespace StackDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            LinearTimeTest();

        }

        private static void LinearTimeTest()
        {
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Generating data");
            stopWatch.Start();
            int[] dave = DataHelper.RandomList(1000000);
            stopWatch.Stop();
            Timing.ShowStopWatch(stopWatch);

            stopWatch.Restart();
            Console.WriteLine("Starting search");
            int loc = Searching.Linear(dave, 7898);
            stopWatch.Stop();
            Timing.ShowStopWatch(stopWatch);
            if (loc != -1)
                Console.WriteLine("found it @" + loc);
            else
                Console.WriteLine("doesn't exist");
        }

        private static void TestLinearSearch()
        {
            int count = 0;
            int pos = -1;
            while (pos == -1)
            {
                count++;
                int[] dave = DataHelper.RandomList(1000);
                DataHelper.Show(dave);

                pos = Searching.Linear(dave, 4646456);
                if (pos == -1)
                    Console.WriteLine("not found");
                else
                    Console.WriteLine("found @" + pos + " took " + count);
            }
        }

        private static void TestLinkedList()
        {
            LListNode a = new LListNode("banana");
            LListNode b = new LListNode("apricot");

            LinkedList list = new LinkedList();
            Console.WriteLine("Count is " + list.Count);

            list.Add(a);
            Console.WriteLine("Count is " + list.Count);
            
            list.Add(b);
            Console.WriteLine("Count is " + list.Count);
            
            //create a new node, set its name and pass the 
            //memory reference on to the add method of
            //the linked list
            list.Add(new LListNode("strawberry"));
            Console.WriteLine("Count is " + list.Count);

            //each one of these is a unique node object
            list.Add(new LListNode("strawberry"));
            Console.WriteLine("Count is " + list.Count);
            list.Add(new LListNode("strawberry"));
            Console.WriteLine("Count is " + list.Count);
            list.Add(new LListNode("strawberry"));
            Console.WriteLine("Count is " + list.Count);
            list.Add(new LListNode("strawberry"));
            Console.WriteLine("Count is " + list.Count);
            list.Add(new LListNode("strawberry"));
            Console.WriteLine("Count is " + list.Count);
            list.Add(new LListNode("strawberry"));
            Console.WriteLine("Count is " + list.Count);

        }
    }
}



