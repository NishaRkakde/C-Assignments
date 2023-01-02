using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSAssigbment3_2
{
    public class StackException : Exception
    {
        public StackException(String message) : base(message) { }
    }
    public class MyStack : ICloneable
    {
        private int[] arr = new int[20];
        private int top = -1;
        private int size;
        public object Clone()
        {
            Console.WriteLine("CLONED_ARRAY");
            MyStack newStack = new MyStack
            {
                arr = this.arr,
                top = this.top,
                size = this.size
            };
            return newStack;
        }
            public int SIZE
        {

            get
            {
                return size;
            }
            set
            {
                this.size = arr.Length;
            }
        }
            public void push(int a)
        {
            try
            {
                if (top == arr.Length - 1)
                {
                    throw new StackException("Fullstack Exception.");
                }
                arr[++top] = a;
                Console.WriteLine($"Pushed {a} onto the stack.");
            }
            catch (StackException st)
            {
                Console.WriteLine(st);
            }
        }
        public void pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new StackException("Emptystack Exception.");
                }
               Console.WriteLine($"{arr[top]} popped.");
               arr[top--] = 0;
            }
            catch (StackException st)
            {
                Console.WriteLine(st);
            }
        }
        public void display()
        {
            Console.WriteLine("\n Printing ");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
