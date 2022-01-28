using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.DataStructures
{
    public class BST
    {
        public Node root;
        public class Node
        {
            public int data;
            public Node left;
            public Node right;

            public Node(int value)
            {
                data = value;
                left = null;
                right = null;
            }            
        }

        public void Insert(int value)
        {           
            root = InsertHelper(root, value);                          
        }

        private Node InsertHelper(Node node, int value)
        {
            if (node == null)            
                return new Node(value);                     

            if (value < node.data)                          
                node.left = InsertHelper(node.left, value);            
            else                         
                node.right = InsertHelper(node.right, value);           

            return node;
        }   
        
        public void InOrder()
        {
            InOrderHelper(root);
        }

        private void InOrderHelper(Node node)
        {
            if (node != null)
            {
                InOrderHelper(node.left);
                Console.WriteLine(node.data);
                InOrderHelper(node.right);
            }            
        }

    }
}
