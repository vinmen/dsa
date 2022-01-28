using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Algorithms.Sorting
{
    public static class Selection
    {
        public static int[] Sort(int[] input)
        {
            int N = input.Length;
            int minIndex;
            int temp;

            for(int i = 0; i < N- 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (input[j] < input[minIndex])
                        minIndex = j;
                }
                temp = input[i];
                input[i] = input[minIndex];
                input[minIndex] = temp;
            }

            return input;
        }
    }
}
