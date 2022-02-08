
namespace dsa.DataStructures
{
    public class MaxHeap
    {
        private int[] heap;
        private int heap_size;

        public MaxHeap(int size)
        {
            heap_size = 0;
            heap = new int[size];
        }

        private int left(int i)
        {
            return (2 * i) + 1;
        }

        private int right(int i)
        {
            return (2 * i) + 2;
        }

        private int parent(int i)
        {
            return (i - 1) / 2;
        }

        private void swap(ref int input1, ref int input2)
        {
            int temp = input1;
            input1 = input2;
            input2 = temp;
        }

        public void Heapify()
        {
            int i = heap_size - 1;
            while(i >= 0)
            {
                if(heap[i] > heap[parent(i)])
                {
                    swap(ref heap[i], ref heap[parent(i)]);
                }
                i--;
            }  
        }
    }
}
