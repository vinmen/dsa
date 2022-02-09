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

        static void RunProblems()
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
            
            //Console.WriteLine(MaxProfit.GetMaxProfit(new int[] {6,7,4,3,1,5}));
            
        }

        private static int LeftChild(int[] arr, int index)
        {
            return arr[2 * index + 1];
        }
        private static int RightChild(int[] arr, int index)
        {
            return arr[2 * index + 2];
        }
        private static int Parent(int[] arr, int index)
        {
            return arr[(index - 1) / 2];
        }
        private static int LeftChildIndex(int index)
        {
            return 2 * index + 1;
        }
        private static int RightChildIndex(int index)
        {
            return 2 * index + 2;
        }
        private static int ParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private static bool LeftChildExists(int index, int heapSize)
        {
            if (heapSize < 2 * index + 1)
                return true;
            return false;
        }

        private static bool RightChildExists(int index, int heapSize)
        {
            if (heapSize < 2 * index + 2)
                return true;
            return false;
        }

        private static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = arr[index1];
        }

        private static int left(int i) 
        {
            return (2 * i) + 1;
        }

        private static int right(int i)
        {
            return (2 * i) + 2;
        }

        private static int parent(int i)
        {
            return (i - 1) / 2;
        }

        private static void swap(ref int input1, ref int input2)
        {
            int temp = input1;
            input1 = input2;
            input2 = temp;
        }

        public static int[] Heapify(int[] arr)
        {
            int N = arr.Length;
            int i = N - 1;            
            int temp;
            while(i >= 0)
            {
                if(arr[i] > arr[parent(i)])
                {
                    swap(ref arr[i], ref arr[parent(i)]);
                    temp = i;
                    while(temp != 0 && left(temp) < N && right(temp) < N)
                    {
                        if(arr[left(temp)] > arr[right(temp)] && arr[temp] < arr[left(temp)])
                        {
                            swap(ref arr[temp], ref arr[left(temp)]);
                            temp = left(temp);
                        }
                        else if(arr[right(temp)] > arr[left(temp)] && arr[temp] < arr[right(temp)])
                        {
                            swap(ref arr[temp], ref arr[right(temp)]);
                            temp = right(temp);
                        } 
                        temp = 0;
                    }
                }
                i--;
            }
            return arr; 
        }

        public static int[] Heapify2(int[] arr)
        {

            return null;
        }

        static void Main()
        {
            int[] input = {6, 5, 4, 3, 2, 1, 0};
            int[] output = Heapify(input);
            foreach(var i in output)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("");
        }    

    }
}
