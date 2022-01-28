namespace dsa.Problems
{
    public static class MaxSubArraySum
    {
        // Iterative method - TLE for large inputs
        public static int GetSum(int[] nums) 
        {
            //[-1,2,3,0,-3,-2,1]
            int N = nums.Length;
            int max_sum = nums[0];
            int temp_sum = 0;

            for(int k = 1; k <= N; k++)
            {
                for(int i = 0; i <= N - k; i++)
                {
                    temp_sum = 0;

                    for(int j = 0; j < k; j++)                    
                        temp_sum = temp_sum + nums[i + j];
                    
                    if(temp_sum > max_sum)                     
                        max_sum = temp_sum;                    
                }       
            }     
            
            return max_sum;
        }

        // Sliding Window - TLE for large inputs
        public static int GetSum2(int[] nums) 
        {            
            int N = nums.Length;
            int max_sum = nums[0];
            int temp_sum;

            for(int j = 1; j <= N; j++)
            {
                temp_sum = 0;
                for(int k = 0; k < j; k++)            
                    temp_sum = temp_sum + nums[k];

                if(temp_sum > max_sum)
                    max_sum = temp_sum;

                for(int i = j; i < N; i++)
                {
                    temp_sum = temp_sum + nums[i] - nums[i - j];
                    if(temp_sum > max_sum)
                        max_sum = temp_sum;
                }
            }
            
            return max_sum;
        }

    }
}