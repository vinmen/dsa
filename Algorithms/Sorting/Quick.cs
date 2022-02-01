
namespace dsa.Algorithms.Sorting
{
    public class Quick
    {
        public static int[] Sort(int[] input)
        {            
            return QuickSortHelper(input, 0 , input.Length - 1);
        }

        private static int[] QuickSortHelper(int[] input, int l, int h)
        {
            if(l < h)
            {
                int p = Partition(input, l, h);
                QuickSortHelper(input, l, p);
                QuickSortHelper(input, p + 1, h);
            }
            return input;            
        }

        private static int Partition(int[] input, int l, int h)
        {
            int pivot = input[h];
            int i = l - 1;
            i++;
            
            for(int j = l; j <= h - 1; j++)
            {
                if(input[j] <= pivot)
                {
                    i++;
                    Swap(input, i, j);
                }
            }
            Swap(input, i + 1, h-1);
            return i + 1;
        }

        private static void Swap(int[] input, int index1, int index2)
        {
            int temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;            
        }
    }
}