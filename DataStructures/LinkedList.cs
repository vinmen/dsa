using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.DataStructures
{
    public class LinkedList<T>
    {
        public Node head;

        public class Node
        {
            public T data;
            public Node next;
            public Node(T value)
            {
                data = value;
                next = null;
            }
        }

        // Append head
        public void Append(T value)
        {
            if (head == null)
            {
                head = new Node(value);
            }                
            else
            {
                Node node = new Node(value);
                node.next = head;
                head = node;
            }                
        }

        //Insert after a node
        public void InsertAfter(Node previous, T value)
        {
            Node temp = head;
            while(temp != previous)
            {
                temp = temp.next;
            }

            Node node = new Node(value);
            node.next = temp.next;
            temp.next = node;
        }

        //Push at the tail
        public void Push(T value)
        {
            if (head == null)
            {
                head = new Node(value);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new Node(value);
            }            
        }

        //Print all nodes
        public void Print()
        {
            Node temp = head;            
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }

   
}
