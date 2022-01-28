using System;
using System.Collections;
using System.Collections.Generic;

using dsa.DataStructures;


namespace dsa.Problems
{
    public class BSTLevelOrder
    {
        Dictionary<int, int> levels = new Dictionary<int, int>();
       
        public void LevelOrder(BST tree)
        {
            LevelOrderHelper(tree.root, 0); 
            
            foreach(KeyValuePair<int, int> kv in levels)
            {
                Console.WriteLine(kv.Key + "::" + kv.Value);
            }

            List<List<int>> output = new List<List<int>>();            
            SortedDictionary<int, List<int>> levels2 = new SortedDictionary<int, List<int>>();

            foreach (KeyValuePair<int, int> kv in levels)
            {
                if (!levels2.ContainsKey(kv.Value))
                    levels2.Add(kv.Value, new List<int> { kv.Key });
                else
                    levels2[kv.Value].Add(kv.Key);
            }

            foreach (List<int> list in levels2.Values)
            {
                output.Add(list);
            }

        }

        public void LevelOrderHelper(BST.Node node, int level)
        {
            if (node == null)
                return;

            LevelOrderHelper(node.left, ++level);            
            levels.Add(node.data, --level);            
            LevelOrderHelper(node.right, ++level);                      
        }
    }
}