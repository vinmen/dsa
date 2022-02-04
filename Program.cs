using System;

using dsa.DataStructures;
using dsa.Problems;
using dsa.Algorithms.Sorting;

using System.Collections.Generic;

namespace dsa
{
    class Program
    {  
        static void RunStack2Tests()
        {
            Stack2<int> stack = new Stack2<int>();
            Console.WriteLine(stack.isEmpty());
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine(stack.isEmpty());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.isEmpty());
        }

        static void RunQueueTests()
        {
            Console.WriteLine(Queue.isEmpty());
            Queue.Enqueue(10);
            Console.WriteLine(Queue.isEmpty());
            Queue.Enqueue(20);
            Queue.Enqueue(30);
            Queue.Enqueue(40);
            Console.WriteLine(Queue.Peek());
            Console.WriteLine(Queue.Dequeue());
            Console.WriteLine(Queue.Dequeue());           
            Console.WriteLine(Queue.Dequeue());
            Console.WriteLine(Queue.Dequeue());
            Console.WriteLine(Queue.isEmpty());
        }

        static void RunStackTests()
        {
            Stack stack = new Stack();
            Console.WriteLine(stack.isEmpty());
            stack.Push(1);
            stack.Push(2);
            Console.WriteLine(stack.isEmpty());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.isEmpty()); 
        }

        static void RunBracketTests()
        {
            Console.WriteLine(BalancedBrackets.CheckBalanced("((()))()()((()()))"));
            Console.WriteLine(BalancedBrackets.CheckBalanced(")((()))()"));
            Console.WriteLine(BalancedBrackets.CheckBalanced("()"));
            Console.WriteLine(BalancedBrackets.CheckBalanced("(()))"));
            Console.WriteLine(BalancedBrackets.CheckBalanced("())(()"));

            Console.WriteLine(BalancedBrackets.CheckBalanced("{[][](([])){()()[]}}"));
            Console.WriteLine(BalancedBrackets.CheckBalanced("{([][]())(){[]}())}"));
        }

        static void LinkedListTest()
        {
            DataStructures.LinkedList<int> list = new DataStructures.LinkedList<int>();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Print();
            Console.WriteLine("****");
            list.Push(4);
            list.Push(5);
            list.Print();
            Console.WriteLine("****");
            list.InsertAfter(list.head.next, 100);
            list.Print();
        }

        static void BSTTest()
        {
            BST tree = new BST();
            //tree.Insert(100);
            //tree.Insert(90);
            //tree.Insert(110);
            //tree.Insert(95);

            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(70);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(55);
            tree.Insert(80);
            tree.Insert(10);
            tree.Insert(90);

            tree.InOrder();

            BSTLevelOrder levelOrder = new BSTLevelOrder();
            levelOrder.LevelOrder(tree);
        }        

        static void Main()
        {
            //RunBracketTests();
            //RunStackTests();
            //RunQueueTests();
            //RunStack2Tests();
            //LinkedListTest();

            //BSTTest();

            //Console.WriteLine("leetcode :: " + NonRepeatingChar.Search3("leetcode"));
            //Console.WriteLine("abccdeefga :: " + NonRepeatingChar.Search3("abccdeefga"));
            //Console.WriteLine("loveleetcode :: " + NonRepeatingChar.Search3("loveleetcode"));
            //Console.WriteLine("loveleetcode :: " + NonRepeatingChar.Search3("loveleetcode"));
            //Console.WriteLine("llllvvveeed :: " + NonRepeatingChar.Search3("llllvvveeed"));
            //Console.WriteLine("z :: " + NonRepeatingChar.Search3("z"));

            //int[] input = { 10, 8, 9, 5, 1, 2, 6, 7, 3, 4};
            //foreach(var i in input)
            //{
            //    Console.Write(i + "\t");
            //}
            //Console.WriteLine("");

            //int[] output = Selection.Sort(input);
            //foreach (var i in output)
            //{
            //    Console.Write(i + "\t");
            //}

            //Console.WriteLine("");
            //Console.WriteLine(ReverseString.Reverse("Hello"));

            //Console.WriteLine(MaxSubArraySum.GetSum(new int[] {5,4,-1,7,8}));
            //Console.WriteLine(MaxSubArraySum.GetSum2(new int[] {5,4,-1,7,8}));
            //Console.WriteLine(MaxSubArraySum.GetSum3(new int[] {5,4,-1,7,8}));

            // int[] input = { 8,7,6,5,4,3,2,1,0 };
            // foreach(var i in input)
            // {
            //    Console.Write(i + "\t");
            // }
            // Console.WriteLine("");

            // int[] output = Merge.Sort(input);
            // foreach (var i in output)
            // {
            //     Console.Write(i + "\t");
            // }

            // int[] input = { 8,7,6,5,4,3,2,1,0 };
            // foreach(var i in input)
            // {
            //    Console.Write(i + "\t");
            // }
            // Console.WriteLine("");

            // int[] output = Quick.Sort(input);
            // foreach (var i in output)
            // {
            //     Console.Write(i + "\t");
            // }              

            // int[] nums1 = {1,2,3,0,0,0};
            // int[] nums2 = {2,5,6};
            // foreach(var i in nums1)
            // {
            //    Console.Write(i + "\t");
            // }
            // Console.WriteLine("");
            // MergeSortedArrays.Merge(nums1, 3, nums2, 3);
            // foreach(var i in nums1)
            // {
            //    Console.Write(i + "\t");
            // }
            
            Console.WriteLine(MaxProfit.GetMaxProfit(new int[] {7,6,4,3,1}));
        }

    }
}
