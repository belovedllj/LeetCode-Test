using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Test
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int StrStr(string haystack, string needle)
        {
            if (haystack == null || needle == null || needle.Length > haystack.Length || needle.Length == 0)
            {
                return -1;
            }            

            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                int j = 0;
                for (; j < needle.Length; j++)
                {                    
                    if(haystack[i + j] != needle[j])
                    {
                        break;
                    }
                }
                if (j == needle.Length) { return i; }
            }
            return -1;
        }
    }
}
