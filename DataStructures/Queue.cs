using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.DataStructures
{ 
    public static class Queue
    {
        private class Node
        {
            public int data;
            public Node next;
            public Node(int value)
            {
                this.data = value;
            }
        }

        private static Node head;
        private static Node tail;       

        public static void Enqueue(int value)
        {
            Node node = new Node(value);
            if (isEmpty())
            {                
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }   
        }

        public static int? Dequeue()
        {
            if (!isEmpty())
            {
                Node temp = head;
                int output = temp.data;
                temp = null;
                head = head.next;
                return output;
            }
            else
                return null;
        }

        public static int Peek()
        {
            return head.data;
        }

        public static bool isEmpty()
        {
            return (head.next == null && tail.next == null);
        }
    }
}
