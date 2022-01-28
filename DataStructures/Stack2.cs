using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.DataStructures
{
    public class Stack2<T>
    { 
        private Node top;

        private class Node
        {
            public T data;
            public Node previous;
            public Node(T value)
            {
                data = value;
            }
        }

        public void Push(T data)
        {
            Node node = new Node(data);
            node.previous = top;
            top = node;
        }

        public T Pop()
        {
            Node temp = top;
            T output = temp.data;
            top = temp.previous;
            temp = null;
            return output;
        }

        public T Peek()
        {
            return top.data;
        }

        public bool isEmpty()
        {
            return (top == null);
        }
    }
}
