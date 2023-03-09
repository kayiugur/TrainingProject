using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.String
{
    public class ReverseWords
    {
        public void reverse(char[] str, int start, int end)
        {
            char temp;

            while (start <= end)
            {
                temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }
        }

        public char[] reverseWords(char[] s)
        {
            int start = 0;
            for(int end = 0; end < s.Length; end++)
            {
                if (s[end] == ' ')
                {
                    reverse(s, start, end);
                    start = end + 1;
                }
            }

            reverse(s, start, s.Length - 1);

            reverse(s, 0, s.Length - 1);
            return s;
        }
    }
}
