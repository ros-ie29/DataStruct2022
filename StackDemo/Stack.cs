using System;

namespace StackDemo
{
    /// <summary>
    /// implements a basic stack
    /// </summary>
    class Stack
    {
        private int[] stack = new int[10];
        private int sp;
        public int Max { get; private set; }

        public Stack()
        {
            sp = 0;
            Max = 10;
        }

        public void Push(int item)
        {
            if (sp == Max)
            {
                Console.WriteLine("Stack full matey");
            }
            else
            {
                stack[sp++] = item;
            }
        }
        public int Pop()
        {
            if (sp == 0)
            {
                Console.WriteLine("empty init");
                return -1;
            }
            else
            {
                return stack[--sp];
                //sp--; 
                //return stack[sp];
            }
        }

        public override string ToString()
        {
            string m = "[sp=" + sp + "]\n";
            for (int i = sp - 1; i >= 0; i--) 
            {
                m += "[" + i + "] -> "  +
                    stack[i].ToString() + " \n";
            }
            return m;
        }
    }
}



