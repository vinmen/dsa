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

            // int[] input = {0, 1, 2, 3, 4, 5, 6};
            // GenerateMaxHeap(input);
            // foreach(var i in input)
            // {
            //     Console.Write(i + "\t");
            // }
            // Console.WriteLine("");
            
            // GenerateMinHeap(input);
            // foreach(var i in input)
            // {
            //     Console.Write(i + "\t");
            // }
            // Console.WriteLine("");
            
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
            arr[index2] = temp;
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

        public static void MinHeapify(int[] arr, int i)
        {
            int N = arr.Length;
            int left = 2 * i + 1;                            // left child                      
            int right = 2 * i + 2;                           // right child
            int smallest = i;

            if(left < N && arr[left] < arr[i])
                smallest = left;
            
            if(right < N && arr[right] < arr[smallest])     // compare against smallest of the two
                smallest = right;

            if(smallest != i)
            {
                Swap(arr, i, smallest);
                MinHeapify(arr, smallest);
            }
        }

        public static void GenerateMinHeap(int[] arr)
        {
            int N = arr.Length;
            for(int i = (N/2) - 1; i >= 0; i--)
            {
                MinHeapify(arr, i);
            }
        }

        public static void MaxHeapify(int[] arr, int i)
        {
            int N = arr.Length;
            int left = 2 * i + 1;                           // left child
            int right = 2 * i + 2;                          // right child
            int largest = i;

            if(left < N && arr[left] > arr[i])
                largest = left;
            
            if(right < N && arr[right] > arr[largest])      // compare against largest of the two
                largest = right;

            if(largest != i)
            {
                Swap(arr, i, largest);
                MaxHeapify(arr, largest);
            }
        }

        public static void GenerateMaxHeap(int[] arr)
        {
            int N = arr.Length;
            for(int i = (N/2) - 1; i >= 0; i--)
            {
                MaxHeapify(arr, i);
            }
        }

        static void Main()
        { 
            BalanceBST problem = new BalanceBST();
            BST bst = problem.Solve(new int[] {5,10,15,30,40,50,60,70,80});
            bst.InOrder(); 
        } 
    }
}
