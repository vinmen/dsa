using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa.Problems
{
    static class NonRepeatingChar
    {
        public static char Search(string data)
        {
            char output = '_';
            List<char> singleList = new List<char>();
            List<char> repeatList = new List<char>();

            foreach(char c in data)
            {
                if(!repeatList.Contains(c))
                {
                    if (!singleList.Contains(c))
                    {
                        singleList.Add(c);
                    }
                    else
                    {
                        repeatList.Add(c);
                        singleList.Remove(c);                        
                    }
                }                
            }
            if (singleList.Count > 0)
                output = singleList[0];

            return output;
        }

        public static char Search2(string data)
        {
            char output = '_';
            bool repeatflag = false;
            List<char> repeatList = new List<char>();

            for(int i = 0; i < data.Length - 1; i++)
            {
                repeatflag = false;
                if (repeatList.Contains(data[i]))
                    continue;
                
                for (int j = i + 1; j < data.Length; j++)
                {                    
                    if (repeatList.Contains(data[j]))
                        continue;
                    else
                    {
                        if (data[i] == data[j])
                        {
                            repeatList.Add(data[i]);
                            repeatflag = true;
                            break;
                        }
                    }                    
                }
                if (repeatflag == false)
                {
                    output = data[i];
                    break;
                }                    
            }

            if (output == -1 && !repeatList.Contains(data[data.Length - 1]))
                output = data[data.Length - 1];

            return output;
        }

        public static int Search3(string s)
        {            
            Dictionary<char, int> ht = new Dictionary<char, int>();
            for(int  i = 0; i < s.Length; i++)
            {
                if (!ht.ContainsKey(s[i]))
                    ht.Add(s[i], 1);
                else
                    ht[s[i]] = (int)(ht[s[i]]) + 1;
            }

            foreach(var key in ht.Keys)
            {
                if((int)(ht[key]) == 1)
                {
                    return s.IndexOf((char)key);
                }
            }

            return -1;
        }
    }
}
