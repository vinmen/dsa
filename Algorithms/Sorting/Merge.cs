
namespace dsa.Algorithms.Sorting
{
    public class Merge
    {
        public static int[] Sort(int[] input)
        {            
            return SortHelper(input, 0, input.Length - 1);
        }

        private static int[] SortHelper(int[] input, int start, int end)
        {  
            if(start >= end)
                return null;     

            int mid = (end - start) / 2;            
            int[] part1 = SortHelper(input, start, mid);
            int[] part2 = SortHelper(input, mid + 1, end);
            int[] output = MergeHelper(part1, part2);

            return output;
        }

        private static int[] MergeHelper(int[] p1, int[] p2)
        {            
            int N1 = p1.Length;
            int N2 = p2.Length;
            int[] output = new int[N1 + N2];

            int index1 = 0;
            int index2 = 0;
            int index3 = 0;

            while(index1 < N1)
            {
                while(index2 < N2)
                {
                    if(p1[index1] <= p2[index2])
                    {
                        output[index3] = p1[index1];
                        index1++;
                        index3++;                        
                    }
                    else
                    {
                        output[index3] = p2[index2];
                        index2++;                         
                    }
                    index3++; 
                }
            }

            while(index1 < N1)
            {
                output[index3] = p1[index1];
                index1++;
                index3++;    
            }

            while(index2 < N2)
            {
                output[index3] = p2[index2];
                index2++;
                index3++;    
            }

            return output;
        }
    }
}