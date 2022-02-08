using System;
using System.Collections.Generic;
using System.Text;

namespace StackDemo
{
    /// <summary>
    /// holds a node of list data
    /// </summary>
    class LListNode
    {
        public LListNode next;
        public string name;
        public LListNode(string givenName)
        {
            name = givenName;
        }
    }

    /// <summary>
    /// creates a basic linked list and associated functions
    /// </summary>
    class LinkedList
    {
        /// <summary>
        /// pointer to start of list
        /// </summary>
        LListNode head = null;
        /// <summary>
        /// create an empty list
        /// </summary>
        public LinkedList()
        {
            head = null;
        }
        /// <summary>
        /// create a list pointing to a node
        /// </summary>
        /// <param name="item">a llinkedlist node object</param>
        public LinkedList(LListNode item)
        {
            head = item;
        }
        public void Add(LListNode item)
        {
            item.next = head;
            head = item;
        }
        /// <summary>
        /// Property that traverses the list to determine its length
        /// </summary>
        public int Count
        {
            get
            {
                int number = 0;
                LListNode current = head;
                while (current != null)
                {
                    number++;
                    current = current.next;
                }
                return number;
            }
        }
    }
}
