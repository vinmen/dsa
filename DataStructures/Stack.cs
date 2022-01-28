using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.DataStructures
{
    public sealed class Stack
    {
        private static int[] arr = new int[100];
        private static int index { get; set; }

        public Stack()
        {
            index = 0;
        }

        public void Push(int value)
        {
            if (index < 100)
                arr[index++] = value;
            else
                throw new StackOverflowException("Stack OverFlow");
        }

        public int Pop()
        {            
            return arr[--index];
        }

        public int Peek()
        {
            if (!isEmpty())
                return arr[index - 1];
            else
                throw new Exception("Empty stack");
        }

        public bool isEmpty()
        {
            if (index == 0)
                return true;

            return false;
        }
    }
}
