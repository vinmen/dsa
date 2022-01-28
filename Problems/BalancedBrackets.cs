using System;
using System.Collections.Generic;
using System.Text;

namespace dsa.Problems
{
    public class BalancedBrackets
    {
        //{}[]()
        public static bool CheckBalanced(string input)
        {            
            if (@"}])".Contains(input[0]) || input.Length % 2 == 1)
                return false;

            Stack<char> tempStack = new Stack<char>();
            foreach (var item in input)
            {
                if (tempStack.Count > 0)
                {
                    if (item.Equals(']') && tempStack.Peek().Equals('['))
                        tempStack.Pop();
                    else if(item.Equals(')') && tempStack.Peek().Equals('('))
                        tempStack.Pop();
                    else if (item.Equals('}') && tempStack.Peek().Equals('{'))
                        tempStack.Pop();
                    else
                        tempStack.Push(item);
                }
                else
                {
                    tempStack.Push(item);
                }   
            }
            if (tempStack.Count > 0)
                return false;

            return true;
        }
    }
}
