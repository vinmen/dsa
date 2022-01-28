using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Problems
{
    public class ReverseString
    {
        public static string Reverse(string input)
        {
            Console.WriteLine(input);           
            return ReverseHelper(input);
        }

        private static string ReverseHelper(string input)
        {
            if (input == "")
                return input;

            var temp = input.Substring(1);   
            return ReverseHelper(temp) + input[0];            
        }
    }
}
