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

        public void LevelOrder(Node root)
        {
            if(root == null)
                return;
                
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while(q.Count > 0)
            {
                Node node = q.Dequeue();
                Console.WriteLine(node.data);
                if(node.left != null)
                    q.Enqueue(node.left);
                if(node.right != null)
                    q.Enqueue(node.right);
            }
        }

    }
}
