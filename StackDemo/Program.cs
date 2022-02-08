using System;

namespace StackDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            TestLinkedList();

            //Console.WriteLine("Hello World!");
            //Stack dave = new Stack();
            
            //dave.Push(13);
            //dave.Push(17);
            //dave.Push(25);
            //Console.WriteLine(dave);
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



